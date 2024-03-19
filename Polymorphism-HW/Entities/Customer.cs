using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_HW.Entities
{
    public class Customer:BaseEntity<int> 
    {
               
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }

        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerRegion { get; set; }


    }
}
