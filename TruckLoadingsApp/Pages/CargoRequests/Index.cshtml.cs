using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TruckLoadingsApp.Data;
using TruckLoadingsApp.Models;

namespace TruckLoadingsApp.Pages.CargoRequests
{
    public class IndexModel : PageModel
    {
        private readonly TruckLoadingsApp.Data.TruckLoadingsAppContext _context;

        public IndexModel(TruckLoadingsApp.Data.TruckLoadingsAppContext context)
        {
            _context = context;
        }

        public IList<CargoRequest> CargoRequest { get;set; } = default!;

        public async Task OnGetAsync()
        {
            CargoRequest = await _context.CargoRequest
                .Include(c => c.Client).ToListAsync();
        }
    }
}
