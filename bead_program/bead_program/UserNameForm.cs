using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bead_program
{
    public partial class UserNameForm : Form
    {
        public string name { get; set; }
        public UserNameForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void UserNameForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {



            this.name = "ASd";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
