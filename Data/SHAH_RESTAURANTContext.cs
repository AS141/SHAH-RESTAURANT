using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SHAH_RESTAURANT.Models;

namespace SHAH_RESTAURANT.Data
{
    public class SHAH_RESTAURANTContext : DbContext
    {
        public SHAH_RESTAURANTContext (DbContextOptions<SHAH_RESTAURANTContext> options)
            : base(options)
        {
        }

        public DbSet<SHAH_RESTAURANT.Models.Customer> Customer { get; set; }

        public DbSet<SHAH_RESTAURANT.Models.Menu> Menu { get; set; }

        public DbSet<SHAH_RESTAURANT.Models.Order> Order { get; set; }
    }
}
