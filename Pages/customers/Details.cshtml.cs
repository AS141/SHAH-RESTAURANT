using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SHAH_RESTAURANT.Data;
using SHAH_RESTAURANT.Models;

namespace SHAH_RESTAURANT.Pages.customers
{
    public class DetailsModel : PageModel
    {
        private readonly SHAH_RESTAURANT.Data.SHAH_RESTAURANTContext _context;

        public DetailsModel(SHAH_RESTAURANT.Data.SHAH_RESTAURANTContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.ID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
