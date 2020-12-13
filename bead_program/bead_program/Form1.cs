using bead_program.Entities;
using bead_program.Forms;
using bead_program.UserControls;
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

            btn_startharvest.Enabled = false;
            btn_startharvest.BackColor = Color.Transparent;


            marketPrice = rn.Next(100000, 150000);
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
                    value = 3000000
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

        private void button1_Click(object sender, EventArgs e)
        {
           

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_balance_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_buydog_Click(object sender, EventArgs e)
        {

           

        }

        private void Panel_main_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (stage == 0)
            {
                stage = 1;
                btn_startharvest.Enabled = true;
                btn_startharvest.BackColor = Color.Green;
                

            }
            else if (stage == 1)
            {
                
            }
           
        }
        

       

        private void btn_selldog_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_startyear_Click(object sender, EventArgs e)
        {
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
            btn_startharvest.Enabled = false;
            btn_startharvest.BackColor = Color.Transparent;
            Harvest harvest = new Harvest(counties[0], players[3], marketPrice, pickedCounties, players, resultCounties);
            panel_main.Controls.Add(harvest);
        }
    }
}
