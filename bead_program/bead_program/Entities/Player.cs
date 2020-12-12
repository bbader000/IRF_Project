using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bead_program.Entities
{
    public class Player
    {
        public int id { get; set; }
        public string name { get; set; }
        public int balance { get; set; }
        public int dogs { get; set; }
        public double bidmax { get; set; }

        public Player()
        {

        }


        public  void BuyDog()
        {
            this.dogs++;
        }

        public void BuyLand(int price)
        {
            this.balance -= price;
        }
    }
}
