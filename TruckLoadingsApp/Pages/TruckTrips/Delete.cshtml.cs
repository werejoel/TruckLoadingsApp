using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TruckLoadingsApp.Data;
using TruckLoadingsApp.Models;

namespace TruckLoadingsApp.Pages.TruckTrips
{
    public class DeleteModel : PageModel
    {
        private readonly TruckLoadingsApp.Data.TruckLoadingsAppContext _context;

        public DeleteModel(TruckLoadingsApp.Data.TruckLoadingsAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TruckTrip TruckTrip { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trucktrip = await _context.TruckTrip.FirstOrDefaultAsync(m => m.TripId == id);

            if (trucktrip == null)
            {
                return NotFound();
            }
            else
            {
                TruckTrip = trucktrip;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trucktrip = await _context.TruckTrip.FindAsync(id);
            if (trucktrip != null)
            {
                TruckTrip = trucktrip;
                _context.TruckTrip.Remove(TruckTrip);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
