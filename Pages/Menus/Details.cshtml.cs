using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SHAH_RESTAURANT.Data;
using SHAH_RESTAURANT.Models;

namespace SHAH_RESTAURANT.Pages.Menus
{
    public class DetailsModel : PageModel
    {
        private readonly SHAH_RESTAURANT.Data.SHAH_RESTAURANTContext _context;

        public DetailsModel(SHAH_RESTAURANT.Data.SHAH_RESTAURANTContext context)
        {
            _context = context;
        }

        public Menu Menu { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Menu = await _context.Menu.FirstOrDefaultAsync(m => m.MenuID == id);

            if (Menu == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
