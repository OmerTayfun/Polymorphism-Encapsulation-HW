using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_HW.Entities
{
    public class Restaurant:BaseEntity<int>
    {
        
        public string RestaurantName { get; set; }
        public string RestaurantAdress { get; set; }
        public string RestaurantKitchenType { get; set; }
        public string ServiceStyle { get; set; }
    }
}
