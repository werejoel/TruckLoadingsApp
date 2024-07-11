using System.ComponentModel.DataAnnotations;
using TruckLoadingsApp.Models.Enums;

namespace TruckLoadingsApp.Models
{
    public class Truck
    {
        [Key]
        public int  TruckId { get; set; }

        [EnumDataType(typeof(TruckType))]
        public TruckType Type { get; set; }

        [Required]
        public string Axload {  get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }
        public double MinWeight { get; set; }
            [Required]
        public double MaxWeight { get; set; }
        public string Size { get; set; }
        public string Capacity { get; set; }
        public bool Availability { get; set; }
        public string Location { get; set; }

        [EnumDataType(typeof(Status))]
        public Status Status { get; set; }




        public int DriverId { get; set; }
        public Driver Driver { get; set; }
        public virtual List<RoutePlan> RoutePlans { get; set; }
        public virtual List<TruckTrip> TruckTrips { get; set; } = new List<TruckTrip> { };
        public virtual List<Report> Reports { get; set; } = new List<Report> { };   
        public bool isDeleted { get; set; } = false;


    }
}
