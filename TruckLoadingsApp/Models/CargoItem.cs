using System.ComponentModel.DataAnnotations;
using TruckLoadingsApp.Models.Enums;

namespace TruckLoadingsApp.Models
{
    public class CargoItem
    {
        [Key]
        public int ItemId { get; set; }
        public double Weight { get; set; }
        [EnumDataType(typeof(FragilityLevel))]
        public FragilityLevel Fragility {  get; set; }
        public string Category { get; set; }
        public  int Quantity { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string Dimensions { get; set; }
        public bool HazardousMaterial { get; set; }
        
        public int RequestId { get; set; }
        public CargoRequest CargoRequest { get; set; }

    }
}
