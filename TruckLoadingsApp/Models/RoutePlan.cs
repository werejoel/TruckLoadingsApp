using System.ComponentModel.DataAnnotations;

namespace TruckLoadingsApp.Models
{
    public class RoutePlan
    {
        [Key]
        public int RouteId { get; set; }
        public int TruckId { get; set; }
        public string RouteName { get; set; }
        public DateTime PostTime { get; set; }
        public string EstimatedTimeTravel { get; set; }
        public double Distance {  get; set; }

        public Truck Truck { get; set; }
        public virtual List<TruckTrip> TruckTrips { get; set; } = new List<TruckTrip> { };
    }
}
