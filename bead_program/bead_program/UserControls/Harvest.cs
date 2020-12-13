using bead_program.Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace bead_program.UserControls
{
    public partial class Harvest : UserControl
    {
        public BindingList<County> pickedCounties { get; set; }
        public BindingList<Player> players { get; set; }
        public BindingList<County> resultCounties { get; set; }
        

        public County pickedCounty { get; set; }
        public Player player  { get; set; }
        public int marketPrice { get; set; }
        Timer harvestTimer = new Timer();
        Timer monthTimer = new Timer();


        
        public int _counter;

        public string[] months = new string[] { "Augusztus", "Szeptember", "Október", "November", "December", "Január", "Február", "Március", "Április", "Május", "Június" };
        public int monthCounter = 0;


        public Harvest()
        {
            
            InitializeComponent();
            btn_results.Enabled = false;
            lbl_price.Text = marketPrice.ToString();



            monthTimer.Interval = 1000;
            monthTimer.Start();
            monthTimer.Tick += MonthTimer_Tick;


            harvestTimer.Interval = 1;
            harvestTimer.Start();
            harvestTimer.Tick += HarvestTimer_Tick;
        }

        private void MonthTimer_Tick(object sender, EventArgs e)
        {
            monthCounter++;
            if (monthCounter == months.Length)
            {
                monthTimer.Stop();
                harvestTimer.Stop();
                btn_results.Enabled = true;
                pickedCounty.income = (_counter * marketPrice);
                pickedCounty.mush = _counter;


                players[3].addIncome(pickedCounty.income);
                resultCounties.Add(pickedCounty);
               
            }
            else
            {
                lbl_actualmonth.Text = months[monthCounter];
            }

            
        }

        private void HarvestTimer_Tick(object sender, EventArgs e)
        {
            if (_counter == pickedCounty.mush)
            {
                harvestTimer.Stop();
                monthTimer.Stop();
                btn_results.Enabled = true;
                pickedCounty.income = (_counter * marketPrice);
                pickedCounty.mush = _counter;


                players[3].addIncome(pickedCounty.income);
                resultCounties.Add(pickedCounty);

            }


            if (_counter%player.dogs== 0)
            {
                harvestTimer.Interval += 5;
            }

            double process = ((double)_counter / (double)pickedCounty.mush);
            lbl_processstatus.Text = Math.Round((process*100)).ToString() + "%";

            _counter++;
            lbl_mushcounter.Text = _counter.ToString();
            lbl_cashcounter.Text = (_counter * marketPrice).ToString();

        }


        private void simulateAI()
        {
            for (int i = 0; i < pickedCounties.Count; i++)
            {
                if (pickedCounties[i].id != 4)
                {
                    int ownerID = int.Parse(pickedCounties[i].ownerID);
                    int pos = getPlayerPosById(ownerID);
                    Player aiPlayer = players[pos];

                    int gotmush = 22 * (int)Math.Round(aiPlayer.dogs * 1.5);

                    if (gotmush >= pickedCounties[i].mush)
                    {
                        pickedCounties[i].income = pickedCounties[i].mush * marketPrice;
                        players[pos].addIncome(pickedCounties[i].income);
                        resultCounties.Add(pickedCounties[i]);
                    }
                    else
                    {
                        pickedCounties[i].income = gotmush * marketPrice;
                        players[pos].addIncome(pickedCounties[i].income);
                        resultCounties.Add(pickedCounties[i]);
                    }

                    
                }


            }
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



        public void buyDogsForAi()
        {
            for (int i = 0; i < pickedCounties.Count; i++)
            {
                int ownerID = int.Parse(pickedCounties[i].ownerID);
                int pos = getPlayerPosById(ownerID);

                if (ownerID != 4)
                {
                    BuyDogResult temp = buyDogsAI(pickedCounties[i].income);
                    players[pos].addIncome(-temp.spentMoney);
                    players[pos].dogs += temp.boughtDogs;
                }


            }
        }

        public BuyDogResult buyDogsAI(int income)
        {
            int _boughtDogs = 0;
            int _spentMoney = 0;

            if (income >= 1000000)
            {
                double temp = income / 1000000;
                int num = (int)Math.Round(temp);

                _boughtDogs = num;
                _spentMoney = num * 1000000;
            }

            BuyDogResult result = new BuyDogResult()
            {
                boughtDogs = _boughtDogs,
                spentMoney = _spentMoney
            };

            return result;


        }

        private void lbl_process_Click(object sender, EventArgs e)
        {

        }

        private void Harvest_Load(object sender, EventArgs e)
        {

        }

        private void lbl_m_Click(object sender, EventArgs e)
        {

        }

        private void lbl_actualmonth_Click(object sender, EventArgs e)
        {

        }

        private void btn_results_Click(object sender, EventArgs e)
        {
            buyDogsForAi();
            simulateAI();
            this.Parent.Controls.Clear();
        }
    }



    public class BuyDogResult
    {
        public int boughtDogs { get; set; }
        public int spentMoney { get; set; }
    }



}
