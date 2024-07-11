using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TruckLoadingsApp.Data;
using TruckLoadingsApp.Models;

namespace TruckLoadingsApp.Pages.RoutePlans
{
    public class DeleteModel : PageModel
    {
        private readonly TruckLoadingsApp.Data.TruckLoadingsAppContext _context;

        public DeleteModel(TruckLoadingsApp.Data.TruckLoadingsAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RoutePlan RoutePlan { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var routeplan = await _context.RoutePlan.FirstOrDefaultAsync(m => m.RouteId == id);

            if (routeplan == null)
            {
                return NotFound();
            }
            else
            {
                RoutePlan = routeplan;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var routeplan = await _context.RoutePlan.FindAsync(id);
            if (routeplan != null)
            {
                RoutePlan = routeplan;
                _context.RoutePlan.Remove(RoutePlan);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
