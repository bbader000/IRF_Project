using bead_program.Entities;
using bead_program.Forms;
using bead_program.UserControls;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public int stage;
        public string playerName;
        public int year;
        public int marketPrice;
        public BindingList<County> counties = new BindingList<County>();
        public BindingList<County> pickedCounties = new BindingList<County>();
        public BindingList<County> resultCounties = new BindingList<County>();
        public BindingList<Player> players = new BindingList<Player>();
        Random rn = new Random();
        

        public Form1()
        {
            getPlayerName();
            InitializeComponent();
            loadPlayers();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            loadCounties();

            lbl_playername.Text = playerName;
            year = 2015;
            btn_startharvest.Enabled = false;
            btn_startharvest.BackColor = Color.Transparent;
            btn_yearresults.Enabled = false;

            lbl_dogs.Text = players[3].dogs.ToString();
            lbl_balance.Text = players[3].balance.ToString();

            marketPrice = rn.Next(50000, 80000);
            panel_main.ControlRemoved += Panel_main_ControlRemoved;



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
                }
                );

                counties[i - 1].calculatePrice();
                counties[i - 1].calculateMush();
                i++;
                

            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_balance_Click(object sender, EventArgs e)
        {

        }

        private void btn_buydog_Click(object sender, EventArgs e)
        {

            if (players[3].balance - 1000000 >= 0)
            {
                players[3].BuyDog();
                lbl_dogs.Text = players[3].dogs.ToString();
                lbl_balance.Text = players[3].balance.ToString();
            }
            else
            {
                MessageBox.Show("Nincs elég pénzed rá", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }  
        
        private void btn_selldog_Click(object sender, EventArgs e)
        {
            if (players[3].dogs != 10)
            {
                players[3].SellDog();
                lbl_dogs.Text = players[3].dogs.ToString();
                lbl_balance.Text = players[3].balance.ToString();
            }
            else
            {
                MessageBox.Show("Neml lehet kevesebb mint 10 kutyád", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void Panel_main_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (stage == 0)
            {
                stage = 1;
                btn_startharvest.Enabled = true;
                btn_startharvest.BackColor = Color.Green;

            }
            else if (stage == 1)
            {
                btn_yearresults.Enabled = true;
                btn_startyear.Enabled = true;

                btn_buydog.Enabled = true;
                btn_selldog.Enabled = true;
                lbl_balance.Text = players[3].balance.ToString();

                if (year == 2020)
                {

                }
                
            }

        }

        private void btn_startyear_Click(object sender, EventArgs e)
        {
            year++;
            lbl_year.Text = year.ToString();

            btn_buydog.Enabled = false;
            btn_selldog.Enabled = false;
            btn_startyear.Enabled = false;
            pickedCounties.Clear();
            stage = 0;
            PickLands pickLand = new PickLands(counties, pickedCounties, players);
            panel_main.Controls.Add(pickLand);
        }

        private void btn_startharvest_Click(object sender, EventArgs e)
        {
            marketPrice = rn.Next(50000, 80000);
            btn_startharvest.Enabled = false;
            btn_startharvest.BackColor = Color.Transparent;
            County plyerCOunty = new County();
            for (int i = 0; i < pickedCounties.Count; i++)
            {
                if (pickedCounties[i].ownerID == "4")
                {
                    plyerCOunty = pickedCounties[i];
                    break;
                }
            }

            Harvest harvest = new Harvest(pickedCounties, players, resultCounties, plyerCOunty, players[3], marketPrice);
           
            panel_main.Controls.Add(harvest);
        }

        private void btn_yearresults_Click(object sender, EventArgs e)
        {
            List<CountyResult> tempList = new List<CountyResult>();

            for (int i = 0; i < resultCounties.Count; i++)
            {
                CountyResult temp = new CountyResult()
                {
                    name = resultCounties[i].name,
                    value = resultCounties[i].value,
                    oldvalue = resultCounties[i].oldvalue,
                    owner = resultCounties[i].owner,
                    mush = resultCounties[i].mush,
                    income = resultCounties[i].income,
                };

                tempList.Add(temp);
            }

            using (var mem = new MemoryStream())
            using (var writer = new StreamWriter("ertekelo.csv"))
            using (var csvWriter = new CsvWriter(writer, System.Globalization.CultureInfo.CurrentCulture))
            {
                csvWriter.Configuration.Delimiter = ";";

                csvWriter.WriteField("Megye");
                csvWriter.WriteField("Vetelar");
                csvWriter.WriteField("Eredeti ar");
                csvWriter.WriteField("Jogosult");
                csvWriter.WriteField("Goma mennyiseg (kg)");
                csvWriter.WriteField("Bevetel");
                csvWriter.NextRecord();

                foreach (CountyResult project in tempList)
                {
                    csvWriter.WriteField(project.name);
                    csvWriter.WriteField(project.value);
                    csvWriter.WriteField(project.oldvalue);
                    csvWriter.WriteField(project.owner);
                    csvWriter.WriteField(project.mush);
                    csvWriter.WriteField(project.income);
                    csvWriter.NextRecord();
                }

                writer.Flush();
                var result = Encoding.UTF8.GetString(mem.ToArray());
                Console.WriteLine(result);
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
    }

   
}
