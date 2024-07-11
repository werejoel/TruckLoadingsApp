using System.ComponentModel.DataAnnotations;

namespace TruckLoadingsApp.Models
{
    public class Driver
    {
        [Key]
        public int DriverId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string LicenseNumber { get; set; }
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Phone { get; set; }



        public virtual List<Truck> Trucks { get; set; } = new List<Truck> { };  
        public bool IsActive { get; set; } = false;
        public bool IsDeleted { get; set; } = false;

    }
}
