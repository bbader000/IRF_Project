using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bead_program.Entities
{
    public class County
    {
        public int id { get; set; }
        public string name { get; set; }
        public int area { get; set; }
        public double forest { get; set; }
        public int rain { get; set; }
        public int value { get; set; }
        public int oldvalue { get; set; }
        public string ownerID { get; set; }
        public string owner { get; set; }
        public int mush { get; set; }
        public int income { get; set; }

        

        public County()
        {
            
        }


        public void calculatePrice()
        {
            int areaPrice = this.area * 100;
            double forestPrice = (this.forest * 10000000);
            int rainPrice = this.rain * 5000;

            int price = areaPrice + (int)Math.Round(forestPrice) + rainPrice;
            this.value = price;
        }

        public void calculateMush()
        {
            double chance = this.rain * this.forest;
            int mush = (int)Math.Round((chance * this.area)/1000);
            this.mush = mush;

        }



        public void setOwner(string name, int id)
        {
            if (this.ownerID != null)
            {
                this.ownerID = this.ownerID + ";" + id.ToString();
                this.owner = this.owner + ", " + name;
            }
            else
            {
                this.ownerID = id.ToString();
                this.owner = name;
            }
        }

        
    }
}
