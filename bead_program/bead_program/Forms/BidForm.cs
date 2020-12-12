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
        Random rn = new Random();
        Timer timerMain = new Timer();
        Timer timerAI = new Timer();

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
            this.lbl_biggestbiddername.Text = "";
            this.lbl_value.Text = counties[county].value.ToString();

            int a = 0;
            startBid();


        }

        private void startBid()
        {
            
        }

        private void BidForm_Load(object sender, EventArgs e)
        {

        }
    }
}
