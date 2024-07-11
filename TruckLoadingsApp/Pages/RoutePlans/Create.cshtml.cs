using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TruckLoadingsApp.Data;
using TruckLoadingsApp.Models;

namespace TruckLoadingsApp.Pages.RoutePlans
{
    public class CreateModel : PageModel
    {
        private readonly TruckLoadingsApp.Data.TruckLoadingsAppContext _context;

        public CreateModel(TruckLoadingsApp.Data.TruckLoadingsAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["TruckId"] = new SelectList(_context.Truck, "TruckId", "Axload");
            return Page();
        }

        [BindProperty]
        public RoutePlan RoutePlan { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.RoutePlan.Add(RoutePlan);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
