using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism_HW.Entities;

namespace Polymorphism_HW
{
    public class NormalCustomer:Customer
    {

        public NormalCustomer()
        {
            {
                Console.WriteLine("Müşteri kayıt işlemi başlatıldı.");
            }
        }
        public bool FirstVisitComplimentary { get; set; }
        public int LoyaltyPoints { get; set; }
    }
}
