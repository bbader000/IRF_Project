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
        public string ownerID { get; set; }
        public string owner { get; set; }
        public int mush { get; set; }
        

        public County()
        {
            
        }

        
    }
}
