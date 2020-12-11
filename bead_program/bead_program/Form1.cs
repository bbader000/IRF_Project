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
using System.Xml;
using System.Xml.Linq;

namespace bead_program
{
    public partial class Form1 : Form
    {
        public List<County> counties = new List<County>();

        public Form1()
        {
            InitializeComponent();
            loadCounties();

            int a = 1;

        }

         void loadCounties()
        {
            XDocument xdocument = XDocument.Load("countydata.xml");
            IEnumerable<XElement> data = xdocument.Root.Elements();

            foreach (var row in data)
            {
                counties.Add(new County()
                {
                    name = row.Element("County").Value,
                    area = int.Parse(row.Element("Area").Value),
                    forest = double.Parse(row.Element("Area").Value),
                    rain = int.Parse(row.Element("Area").Value)
                }
                );






            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
