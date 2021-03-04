using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SHAH_RESTAURANT.Data;
using SHAH_RESTAURANT.Models;

namespace SHAH_RESTAURANT.Pages.Orders
{
    public class DetailsModel : PageModel
    {
        private readonly SHAH_RESTAURANT.Data.SHAH_RESTAURANTContext _context;

        public DetailsModel(SHAH_RESTAURANT.Data.SHAH_RESTAURANTContext context)
        {
            _context = context;
        }

        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.Order
                .Include(o => o.Menu).FirstOrDefaultAsync(m => m.OrderID == id);

            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
