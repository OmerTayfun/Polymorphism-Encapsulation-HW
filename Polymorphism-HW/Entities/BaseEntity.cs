using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_HW.Entities
{
    public class BaseEntity<TId> // Generic Type Örneği
    {
        public TId Id { get; set; }
        
    }
}
