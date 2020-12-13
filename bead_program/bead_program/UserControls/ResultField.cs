using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bead_program.UserControls
{
    public partial class ResultField : UserControl
    {
        public ResultField(int pos , string name, int balance)
        {
            InitializeComponent();
            lbl_pos.Text = pos.ToString();
            lbl_name.Text = name;
            lbl_balance.Text = pos.ToString();
            
        }

        private void ResultField_Load(object sender, EventArgs e)
        {

        }
    }
}
