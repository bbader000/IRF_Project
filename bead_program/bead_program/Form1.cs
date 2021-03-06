﻿using bead_program.Entities;
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
using System.Reflection;
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
                if (nameform.name == "")
                {
                    this.playerName = "Játékos";
                }
                else
                {
                    this.playerName = nameform.name;
                }

                
            }
            
        }

        void loadCounties()
        {         
 
            XDocument xdocument = XDocument.Load(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\Data\countydata.xml"))) ;
            IEnumerable <XElement> data = xdocument.Root.Elements();
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
                    ResultForm result = new ResultForm(players);
                    result.ShowDialog();
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
            try
            {
                CSVWriter writer = new CSVWriter();
                bool isOk = writer.writeCSV(resultCounties);

                if (isOk)
                {
                    MessageBox.Show("Sikeres exportálás", "Exportálás", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Sikertelen exportálás, nem lett mentési útvonal kiválasztva", "Exportálás", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
                
           

            }
            catch (Exception)
            {

                MessageBox.Show("Az exportálás nem sikerült", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
