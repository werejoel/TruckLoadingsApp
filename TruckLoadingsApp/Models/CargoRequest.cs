using System.ComponentModel.DataAnnotations;

namespace TruckLoadingsApp.Models
{
    public class CargoRequest
    {
        [Key]
        public int RequestId { get; set; }
        public int ClientId { get; set; }
        public string TransportionRequirements { get; set; }
        public float Quantity { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime PickUpDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DeliveryDate { get; set; }
        public string Description { get; set; }


        public User Client { get; set; }
        public virtual List<CargoItem>  CargoItems { get; set; }
        public virtual List<TruckTrip> TruckTrips { get; set; }

    }
}
