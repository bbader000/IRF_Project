using bead_program.Entities;
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

namespace bead_program.Forms
{
    public partial class ResultForm : Form
    {
        public BindingList<Player> players { get; set; }
        

        public ResultForm(BindingList<Player> players)
        {
            this.players = players;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            List<Player> sortedList = players.OrderBy(o => o.balance).ToList();
            sortedList.Reverse();

            for (int i = 0; i < sortedList.Count; i++)
            {
                ResultField temp = new ResultField(i + 1, sortedList[i].name, sortedList[i].balance);
                resultpanel.Controls.Add(temp);
            }


        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }

        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            System.Windows.Forms.Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
