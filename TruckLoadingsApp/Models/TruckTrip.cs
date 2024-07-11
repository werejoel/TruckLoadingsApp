using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using TruckLoadingsApp.Models.Enums;

namespace TruckLoadingsApp.Models
{
    public class TruckTrip
    {
        [Key]
        public int TripId { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime StatingTime { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndingTime { get; set; }
        public TripStatus Status { get; set; }


       
    }
}
