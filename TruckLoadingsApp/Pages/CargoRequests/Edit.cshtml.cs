using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TruckLoadingsApp.Data;
using TruckLoadingsApp.Models;

namespace TruckLoadingsApp.Pages.CargoRequests
{
    public class EditModel : PageModel
    {
        private readonly TruckLoadingsApp.Data.TruckLoadingsAppContext _context;

        public EditModel(TruckLoadingsApp.Data.TruckLoadingsAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CargoRequest CargoRequest { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargorequest =  await _context.CargoRequest.FirstOrDefaultAsync(m => m.RequestId == id);
            if (cargorequest == null)
            {
                return NotFound();
            }
            CargoRequest = cargorequest;
           ViewData["ClientId"] = new SelectList(_context.User, "UserId", "Email");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CargoRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CargoRequestExists(CargoRequest.RequestId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CargoRequestExists(int id)
        {
            return _context.CargoRequest.Any(e => e.RequestId == id);
        }
    }
}
