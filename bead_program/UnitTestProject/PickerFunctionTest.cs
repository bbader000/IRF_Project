using bead_program;
using bead_program.Forms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    
    public  class PickerFunctionTest
    {


        [
            Test,
            TestCase(9000000, 9, 9000000),
            TestCase(2300000, 2, 2000000),
            TestCase(970000, 0, 0)
        ]
        public void PickerTest(int income, int boughtDogs, int spentMoney)
        {
            var form = new Form1();

            var result = form.buyDogsAI(income);


            Assert.AreEqual(spentMoney, result.spentMoney);
            Assert.AreEqual(boughtDogs, result.boughtDogs);
            
        }

    }
}
