﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SHAH_RESTAURANT.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int MenuID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }

        public Menu Menu { get; set; }
        public Customer Customer { get; set; }
    }
}

