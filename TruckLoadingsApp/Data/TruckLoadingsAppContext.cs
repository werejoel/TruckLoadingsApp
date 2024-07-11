using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TruckLoadingsApp.Models;

namespace TruckLoadingsApp.Data
{
    public class TruckLoadingsAppContext : DbContext
    {
        public TruckLoadingsAppContext (DbContextOptions<TruckLoadingsAppContext> options)
            : base(options)
        {
        }

        public DbSet<TruckLoadingsApp.Models.User> User { get; set; } = default!;
        public DbSet<TruckLoadingsApp.Models.Truck> Truck { get; set; } = default!;
        public DbSet<TruckLoadingsApp.Models.Driver> Driver { get; set; } = default!;
        public DbSet<TruckLoadingsApp.Models.CargoRequest> CargoRequest { get; set; } = default!;
        public DbSet<TruckLoadingsApp.Models.RoutePlan> RoutePlan { get; set; } = default!;
        public DbSet<TruckLoadingsApp.Models.Report> Report { get; set; } = default!;
        public DbSet<TruckLoadingsApp.Models.CargoItem> CargoItem { get; set; } = default!;
        public DbSet<TruckLoadingsApp.Models.TruckTrip> TruckTrip { get; set; } = default!;
    }
}
