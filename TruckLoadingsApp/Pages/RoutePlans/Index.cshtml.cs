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
    public class IndexModel : PageModel
    {
        private readonly TruckLoadingsApp.Data.TruckLoadingsAppContext _context;

        public IndexModel(TruckLoadingsApp.Data.TruckLoadingsAppContext context)
        {
            _context = context;
        }

        public IList<RoutePlan> RoutePlan { get;set; } = default!;

        public async Task OnGetAsync()
        {
            RoutePlan = await _context.RoutePlan
                .Include(r => r.Truck).ToListAsync();
        }
    }
}
