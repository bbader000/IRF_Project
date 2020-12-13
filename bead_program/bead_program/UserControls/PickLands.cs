using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bead_program.Entities;
using bead_program.Forms;

namespace bead_program.UserControls
{
    public partial class PickLands : UserControl
    {
        

        public BindingList<County> counties { get; set; }
        public BindingList<County> pickedCounties { get; set; }
        public BindingList<County> countyResult { get; set; }
        public BindingList<Player> players { get; set; }
        public bool isPlayerPicked;

        public Random rn = new Random();

        public PickLands(BindingList<County> counties, BindingList<County> pickedCounties, BindingList<Player> players)
        {
            InitializeComponent();

            this.counties = counties;
            this.pickedCounties = pickedCounties;
            this.players = players;
            dgw_lands.DataSource = counties;
            dgw_lands.Columns["id"].Visible = false;
            //dgw_lands.Columns["mush"].Visible = false;
            btn_startyear.Enabled = false;
            btn_startyear.Enabled = false;





        }


        private void PickLands_Load(object sender, EventArgs e)
        {

        }

        private void checkIfBid()
        {
            List<int> bids = new List<int>();
            for (int i = 0; i < counties.Count; i++)
            {
                if (counties[i].ownerID != null && counties[i].ownerID.Contains(';'))
                {
                    bids.Add(i);
                }
            }

            for (int i = 0; i < bids.Count; i++)
            {
                string[] bidders = counties[bids[i]].ownerID.Split(';');
                if (checkIfPlayerBid(bidders))
                {
                    //játékos licit
                    bidPlayer(bidders, bids[i]);
                }
                else
                {
                    //gép licit
                    bidAI(bidders, bids[i]);
                }
            }




        }

        private void buyLands()
        {
            for (int i = 0; i < counties.Count; i++)
            {
                if (counties[i].ownerID != null)
                {
                    players[getPlayerPosById(int.Parse(counties[i].ownerID))].BuyLand(counties[i].value);
                    pickedCounties.Add(counties[i]);
                    counties.RemoveAt(i);
                    i--;
                }
            }
        }

        private void bidPlayer(string[] temp, int county)
        {


            List<Player> bidders = new List<Player>();

            for (int i = 0; i < temp.Length; i++)
            {
                Player player = getPlayerById(int.Parse(temp[i]));
                player.bidmax = player.balance * 0.50;
                bidders.Add(player);
            }

            BidForm bidForm = new BidForm(counties, players, bidders, county);
            if (bidForm.ShowDialog() == DialogResult.OK)
            {
                bidWinnerPick(county, bidForm.currentValue, bidForm.buyerID);
                dgw_lands.Refresh();


                if (bidForm.buyerID != 4)
                {
                    newPick(getPlayerPosById(4));
                }

                for (int i = 0; i < bidders.Count; i++)
                {
                    if (bidders[i].id != bidForm.buyerID)
                    {
                        newPick(getPlayerPosById(bidders[i].id));
                    }
                    dgw_lands.Refresh();
                }

                





            }

        }

        private void bidAI(string[] temp, int county)
        {
            List<Player> bidders = new List<Player>();

            for (int i = 0; i < temp.Length; i++)
            {
                Player player = getPlayerById(int.Parse(temp[i]));
                player.bidmax = player.balance * 0.50;
                bidders.Add(player);
            }


            int currentValue = counties[county].value;
            bool sold = false;
            int buyerID = 0;
            int potentialBuy = 0;
            while (!sold)
            {

                for (int i = 0; i < bidders.Count; i++)
                {

                    if (buyerID == bidders[i].id && potentialBuy > 0)
                    {
                        sold = true;
                        break;
                    }


                    double chance = (bidders[i].bidmax - currentValue) / bidders[i].bidmax;
                    double roll = rn.NextDouble();
                    if (roll <= chance)
                    {
                        buyerID = bidders[i].id;
                        currentValue += 500000;
                        potentialBuy = 0;

                    }
                    else
                    {
                        potentialBuy++;
                    }
                }


            }

            bidWinnerPick(county, currentValue, buyerID);

            for (int i = 0; i < bidders.Count; i++)
            {
                if (bidders[i].id != buyerID)
                {
                    int pos = getPlayerPosById(bidders[i].id);
                    newPick(pos);
                }
            }
            dgw_lands.Refresh();





        }

        public void bidWinnerPick(int county, int currentValue, int buyerID)
        {
            Player buyerPlayer = getPlayerById(buyerID);
            counties[county].ownerID = buyerPlayer.id.ToString();
            counties[county].owner = buyerPlayer.name;

            counties[county].oldvalue = counties[county].value;
            counties[county].value = currentValue;
        }

        public int getPlayerPosById(int id)
        {
            int temp = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].id == id)
                {
                    temp = i;
                }
            }
            return temp;
        }

        private bool checkIfPlayerBid(string[] temp)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == "4")
                {
                    return true;
                }
            }
            return false;
        }

        private void pickLandsFirst()
        {
            int[] ids = getIdOrder();
            for (int i = 0; i < ids.Length; i++)
            {
                //System.Threading.Thread.Sleep(1000);
                for (int j = 0; j < players.Count; j++)
                {

                    if (players[j].id == ids[i])
                    {
                        int temp = rn.Next(0, counties.Count - 1);

                        if (counties[temp].ownerID != null)
                        {
                            bool wannaFight = checkOwner(j, temp);
                            if (wannaFight)
                            {
                                counties[temp].setOwner(players[j].name, players[j].id);

                            }
                            else
                            {
                                newPick(j);
                            }
                        }
                        else
                        {
                            counties[temp].setOwner(players[j].name, players[j].id);

                            break;
                        }


                    }

                }
                dgw_lands.Refresh();
            }
            

        }

        private int getNotNull()
        {
            int _counter = 0;
            for (int k = 0; k < counties.Count; k++)
            {
                if (counties[k].owner == null)
                {
                    _counter++;
                }

            }
            return _counter;
        }

        private void newPick(int j)
        {
            int notnull = getNotNull();

            if (notnull != 0)
            {
                bool ok = true;
                while (ok)
                {
                    int newPick = rn.Next(0, counties.Count);
                    if (counties[newPick].owner == null)
                    {
                        counties[newPick].setOwner(players[j].name, players[j].id);

                        ok = false;
                    }
                }
            }


        }

        private bool checkOwner(int j, int temp)
        {
            

            int rrr = rn.Next(0, 100);

            if (rrr < 50)
            {
                return true;
            }
            else
            {
                return false;
            }





        }

        private int[] getIdOrder()
        {
            int[] ids = new int[3];

            for (int i = 0; i < 3; i++)
            {
                int temp = rn.Next(1, 4);
                if (!ids.Contains(temp))
                {
                    ids[i] = temp;
                }
                else
                {
                    i--;
                }
            }
            return ids;
        }

        private Player getPlayerById(int id)
        {
            Player player = new Player();
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].id == id)
                {
                    player = players[i];
                }
            }


            return player;
        }

        private void btn_pick_Click(object sender, EventArgs e)
        {
            btn_pick.Enabled = false;
            btn_pass.Enabled = false;
            btn_startyear.Enabled = true;

            County county = (County)dgw_lands.CurrentRow.DataBoundItem;
            county.setOwner(players[3].name, players[3].id);
                
            pickLandsFirst();
            checkIfBid();
            btn_startyear.Enabled = true;

        }
        private void btn_pass_Click(object sender, EventArgs e)
        {
            btn_pick.Enabled = false;
            btn_pass.Enabled = false;
            btn_startyear.Enabled = true;

            pickLandsFirst();
            checkIfBid();
            btn_startyear.Enabled = true;
        }

        private void btn_startyear_Click(object sender, EventArgs e)
        {
            checkIfPlayerPlay();
            buyLands();
            this.Parent.Controls.Clear();

        }

        private void checkIfPlayerPlay()
        {
            for (int i = 0; i < pickedCounties.Count; i++)
            {
                if (pickedCounties[i].id == 4)
                {
                    isPlayerPicked = true;
                    break;
                }
            }
        }
    }
}
