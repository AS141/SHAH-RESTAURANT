﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SHAH_RESTAURANT.Data;
using SHAH_RESTAURANT.Models;

namespace SHAH_RESTAURANT.Pages.Orders
{
    public class CreateModel : PageModel
    {
        private readonly SHAH_RESTAURANT.Data.SHAH_RESTAURANTContext _context;

        public CreateModel(SHAH_RESTAURANT.Data.SHAH_RESTAURANTContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MenuID"] = new SelectList(_context.Menu, "MenuID", "MenuID");
            return Page();
        }

        [BindProperty]
        public Order Order { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Order.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
