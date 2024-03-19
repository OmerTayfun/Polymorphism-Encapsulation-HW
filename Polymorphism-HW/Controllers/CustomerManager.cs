using Polymorphism_HW.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_HW.Controllers
{
    public class CustomerManager
    {
        private Customer _customer; 
        

        public CustomerManager(Customer customer)
        {
                _customer = customer;
                        
        }
        
        public static void VipInfo()
        {
            Console.WriteLine("Vip Hizmeti Aktif");
        }
        public static void NormalCustomer()
        {
            Console.WriteLine("Normal Müşteri hizmeti aktif");
        }
    }
}
