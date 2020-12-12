using bead_program.Entities;
using bead_program.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace bead_program
{
    public partial class Form1 : Form
    {
        public string playerName;
        public int year;
        public BindingList<County> counties = new BindingList<County>();
        public BindingList<County> pickedCounties = new BindingList<County>();
        public BindingList<Player> players = new BindingList<Player>();
        Random rn = new Random();
        

        public Form1()
        {
            getPlayerName();
            InitializeComponent();
            loadPlayers();
            this.label1.Text = playerName;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            loadCounties();
            




        }

        private void loadPlayers()
        {
            string[] names = new string[] {"Joe","Lőrinc","Angela" };

            for (int i = 1; i < 4; i++)
            {
                players.Add(new Player()
                {
                    id = i,
                    name = names[i-1],
                    balance = 20000000,
                    dogs = 10,

                });
            }
            players.Add(new Player()
            {
                id = 4,
                name = playerName,
                balance = 20000000,
                dogs = 10,

            });

        }

        private void getPlayerName()
        {
            UserNameForm nameform = new UserNameForm();
            if (nameform.ShowDialog() == DialogResult.OK)
            {
                this.playerName = nameform.name;
            }
            
        }

        void loadCounties()
        {
            XDocument xdocument = XDocument.Load("countydata.xml");
            IEnumerable<XElement> data = xdocument.Root.Elements();
            int i = 1;
            foreach (var row in data)
            {
                counties.Add(new County()
                {
                    id = i,
                    name = row.Element("County").Value,
                    area = int.Parse(row.Element("Area").Value),
                    forest = double.Parse(row.Element("Forest").Value),
                    rain = int.Parse(row.Element("Rain").Value),
                    value = 3000000
                }
                );
                i++;
                

            }
            dataGridView1.DataSource = counties;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["mush"].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //County row = (County)dataGridView1.CurrentRow.DataBoundItem;
            //row.owner = "Me";
            //dataGridView1.Refresh();


            startGame();

        }

        private void startGame()
        {
            this.year = 2016;
            lbl_year.Text = year.ToString();

            pickLandsFirst();
            checkIfBid();

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

        private void bidPlayer(string[] temp, int county)
        {

            
            //List<Player> bidders = new List<Player>();

            //for (int i = 0; i < temp.Length; i++)
            //{
            //    Player player = getPlayerById(int.Parse(temp[i]));
            //    player.bidmax = player.balance * 0.70;
            //    bidders.Add(player);
            //}



        }

        private void bidAI(string[] temp, int county)
        {
            List<Player> bidders = new List<Player>();

            for (int i = 0; i < temp.Length; i++)
            {
                Player player = getPlayerById(int.Parse(temp[i]));
                player.bidmax = player.balance * 0.70;
                bidders.Add(player);
            }


            int currentValue = counties[county].value;
            bool sold = false;
            int buyerID = 0;
            int potentialBuy = 0;
            while(!sold)
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
                    if (roll <= chance )
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

            counties[county].ownerID = buyerID.ToString();
            Player buyerPlayer = getPlayerById(buyerID);
            counties[county].owner = buyerPlayer.name;
            counties[county].value = currentValue;

            for (int i = 0; i < bidders.Count; i++)
            {
                if (bidders[i].id != buyerID)
                {
                    int pos = getPlayerPosById(bidders[i].id);
                    newPick(pos);
                }
            }
            dataGridView1.Refresh();





        }

        private int getPlayerPosById(int id)
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
                                counties[temp].ownerID = counties[temp].ownerID.ToString() + ";" + players[j].id;
                                counties[temp].owner = counties[temp].owner + ", " + players[j].name;
                            }
                            else
                            {
                                newPick(j);
                            }
                        }
                        else
                        { 
                            counties[temp].ownerID = players[j].id.ToString();
                            counties[temp].owner = players[j].name;
                            break;
                        }


                    }

                }

            }
            dataGridView1.Refresh();

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
                        counties[newPick].ownerID = players[j].id.ToString();
                        counties[newPick].owner = players[j].name;
                        ok = false;
                    }
                }
            }

            
        }

        private bool checkOwner(int j, int temp)
        {
            bool decision = false;

            int rrr = rn.Next(0, 100);

            if (rrr< 50)
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




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_balance_Click(object sender, EventArgs e)
        {

        }
    }
}
