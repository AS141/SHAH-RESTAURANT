using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SHAH_RESTAURANT.Models
{
    public class Menu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MenuID { get; set; }
        public string DishName { get; set; }
        public string DitearyRestriction { get; set; }
        public int Price { get; set; }

        public int Rating { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
