using System.ComponentModel.DataAnnotations;
using TruckLoadingsApp.Models.Enums;

namespace TruckLoadingsApp.Models
{
    public class User
    {
        [Key]
       public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Phone { get; set; }
        public UserRole Role { get; set; }
        public List<Report> Reports  { get; set; } = new List<Report> { };
        public List<CargoRequest> CargoRequests { get; set; } = new List<CargoRequest> { };

       

        
    }
}
