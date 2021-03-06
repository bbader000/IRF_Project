﻿using System;
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


        public void BuyDog()
        {
            this.balance -= 100000;
            this.dogs += 1;
        }

        public void SellDog()
        {
            this.balance += 50000;
            this.dogs -= 1;
        }

        public void BuyLand(int price)
        {
            this.balance -= price;
        }

        public void addIncome(int income)
        {
            this.balance += income;
        }
    }
}
