using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHAH_RESTAURANT.Models
{ 
    public class Customer
    {
        public int ID { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public int Mobile { get; set; }
        
        public ICollection<Order> Orders { get; set; }

        
    }
}
