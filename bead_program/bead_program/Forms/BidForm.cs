using bead_program.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bead_program.Forms
{
    public partial class BidForm : Form
    {
        public BindingList<County> counties { get; set; }
        public BindingList<Player> players { get; set; }
        public List<Player> bidders { get; set; }
        public int county { get; set; }


        public int _tickCounter;
        public int currentValue;
        public int buyerID;
        Random rn = new Random();
        Timer timerMain = new Timer();


        public BidForm(BindingList<County> counties, BindingList<Player> players, List<Player> bidders, int county)
        {
            this.counties = counties;
            this.players = players;
            this.bidders = bidders;
            this.county = county;



            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.lbl_countyname.Text = counties[county].name;
            this.lbl_startvalue.Text = counties[county].value.ToString();
            currentValue = counties[county].value;
            this.lbl_biggestbiddername.Text = "";
            this.lbl_value.Text = counties[county].value.ToString();



            removePlayer();
            startBid();


        }

        private void removePlayer()
        {
            for (int i = 0; i < bidders.Count; i++)
            {
                if (bidders[i].id == 4)
                {
                    bidders.RemoveAt(i);
                }
            }
        }

        private void startBid()
        {
            timerMain.Interval = 1000;
            timerMain.Tick += TimerMain_Tick;
            timerMain.Start();


        }

        private void TimerMain_Tick(object sender, EventArgs e)
        {
            if (10 - _tickCounter <= 3)
            {
                lbl_timer.ForeColor = Color.Red;
            }


            lbl_timer.Text = (10 - _tickCounter).ToString();

            if (_tickCounter == 10)
            {
                timerMain.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else if (_tickCounter % 2 == 0)
            {
                for (int i = 0; i < bidders.Count; i++)
                {
                    if (buyerID != bidders[i].id)
                    {
                        double chance = (bidders[i].bidmax - currentValue) / bidders[i].bidmax;
                        double roll = rn.NextDouble();
                        if (roll <= chance)
                        {
                            buyerID = bidders[i].id;
                            currentValue += 500000;
                            lbl_value.Text = currentValue.ToString();
                            lbl_biggestbiddername.Text = bidders[i].name;
                            buyerID = bidders[i].id;
                            _tickCounter = 0;
                            lbl_timer.Text = (10 - _tickCounter).ToString();
                            lbl_timer.ForeColor = Color.Black;
                        }
                    }

                }
            }

            _tickCounter++;

        }

        private void BidForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_bid_Click(object sender, EventArgs e)
        {
            if (currentValue + 500000 > players[3].balance)
            {
                MessageBox.Show("Nincs elég pénzed", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _tickCounter = 0;
                lbl_timer.Text = (10 - _tickCounter).ToString();
                currentValue += 500000;
                lbl_value.Text = currentValue.ToString();
                lbl_biggestbiddername.Text = players[3].name;
                buyerID = players[3].id;
                lbl_timer.ForeColor = Color.Black;
            }


        }



        private void BidForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.Equals((sender as Button).Name, @"CloseButton"))
            {
                if (buyerID == 0)
                {
                    for (int i = 0; i < bidders.Count; i++)
                    {
                        if (bidders[i].id != 4)
                        {
                            buyerID = bidders[i].id;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
                
            }

    


        }
    }
}
