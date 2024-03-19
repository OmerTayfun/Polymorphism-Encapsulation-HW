using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism_HW.Entities;

namespace Polymorphism_HW
{
    public class VipCustomer:Customer
    {
        public VipCustomer()
        {
            {
                Console.WriteLine("Müşteri kayıt işlemi başlatıldı.");
            }
        }
        public double VipDiscount {  get; set; }
        public string VipService { get; set; }
        public bool PriorityReservation { get; set; }
        public string FavoriteFood { get; set; }
        public string FavoriteRestaurant { get; set; }



    }
}
