using bead_program.Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace bead_program.UserControls
{
    public partial class Harvest : UserControl
    {
        public BindingList<County> pickedCountiesH { get; set; }
        public BindingList<Player> playersH { get; set; }
        public BindingList<County> resultCountiesH { get; set; }
        

        public County pickedCountyH { get; set; }
        public Player playerH  { get; set; }
        public int marketPriceH { get; set; }
        Timer harvestTimer = new Timer();
        Timer monthTimer = new Timer();


        
        public int _counter;

        public string[] months = new string[] { "Augusztus", "Szeptember", "Október", "November", "December", "Január", "Február", "Március", "Április", "Május", "Június" };
        public int monthCounter = 0;


        public Harvest(BindingList<County> pickedCountiesH = null, BindingList<Player> playersH = null, BindingList<County> resultCountiesH = null, County pickedCountyH = null, Player playerH = null, int marketPriceH = 0)
        {
            this.pickedCountiesH = pickedCountiesH;
            this.playersH = playersH;
            this.resultCountiesH = resultCountiesH;
            this.pickedCountyH = pickedCountyH;
            this.playerH = playerH;
            this.marketPriceH = marketPriceH;
            InitializeComponent();
            btn_results.Enabled = false;
            lbl_price.Text = marketPriceH.ToString();



            monthTimer.Interval = 2000;
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
                pickedCountyH.income = (_counter * marketPriceH);
                pickedCountyH.mush = _counter;


                playersH[3].addIncome(pickedCountyH.income);
                resultCountiesH.Add(pickedCountyH);
               
            }
            else
            {
                lbl_actualmonth.Text = months[monthCounter];
            }

            
        }

        private void HarvestTimer_Tick(object sender, EventArgs e)
        {
            if (_counter == pickedCountyH.mush)
            {
                harvestTimer.Stop();
                monthTimer.Stop();
                btn_results.Enabled = true;
                pickedCountyH.income = (_counter * marketPriceH);
                pickedCountyH.mush = _counter;


                playersH[3].addIncome(pickedCountyH.income);
                resultCountiesH.Add(pickedCountyH);

            }


            if (_counter%playerH.dogs== 0)
            {
                harvestTimer.Interval += 5;
            }

            double process = ((double)_counter / (double)pickedCountyH.mush);
            lbl_processstatus.Text = Math.Round((process*100)).ToString() + "%";

            _counter++;
            lbl_mushcounter.Text = _counter.ToString();
            lbl_cashcounter.Text = (_counter * marketPriceH).ToString();

        }


        private void simulateAI()
        {
            for (int i = 0; i < pickedCountiesH.Count; i++)
            {
                if (pickedCountiesH[i].ownerID != "4")
                {
                    int ownerID = int.Parse(pickedCountiesH[i].ownerID);
                    int pos = getPlayerPosById(ownerID);
                    Player aiPlayer = playersH[pos];

                    int gotmush = 22 * (int)Math.Round(aiPlayer.dogs * 1.3);

                    if (gotmush >= pickedCountiesH[i].mush)
                    {
                        pickedCountiesH[i].income = pickedCountiesH[i].mush * marketPriceH;
                        playersH[pos].addIncome(pickedCountiesH[i].income);
                        resultCountiesH.Add(pickedCountiesH[i]);
                    }
                    else
                    {
                        pickedCountiesH[i].income = gotmush * marketPriceH;
                        playersH[pos].addIncome(pickedCountiesH[i].income);
                        resultCountiesH.Add(pickedCountiesH[i]);
                    }

                    
                }


            }
        }

        public int getPlayerPosById(int id)
        {
            int temp = 0;
            for (int i = 0; i < playersH.Count; i++)
            {
                if (playersH[i].id == id)
                {
                    temp = i;
                }
            }
            return temp;
        }

        public void buyDogsForAi()
        {
            for (int i = 0; i < pickedCountiesH.Count; i++)
            {
                int ownerID = int.Parse(pickedCountiesH[i].ownerID);
                int pos = getPlayerPosById(ownerID);

                if (ownerID != 4)
                {
                    BuyDogResult temp = buyDogsAI(pickedCountiesH[i].income);
                    playersH[pos].addIncome(-temp.spentMoney);
                    playersH[pos].dogs += temp.boughtDogs;
                }


            }
        }

        public BuyDogResult buyDogsAI(int income)
        {
            int _boughtDogs = 0;
            int _spentMoney = 0;

            if (income >= 250000)
            {
                int spendable = (int)Math.Round(income * 0.2);
                double temp = spendable / 100000;
                int num = (int)Math.Round(temp);

                _boughtDogs = num;
                _spentMoney = num * 100000;
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
            int a = 0;
            simulateAI();
            buyDogsForAi();
            

            
            this.Parent.Controls.Clear();
        }
    }



    public class BuyDogResult
    {
        public int boughtDogs { get; set; }
        public int spentMoney { get; set; }
    }



}
