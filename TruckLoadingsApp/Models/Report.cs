using System.ComponentModel.DataAnnotations;

namespace TruckLoadingsApp.Models
{
    public class Report
    {
        [Key]
        public int ReportId { get; set; }
        public int UserId { get; set; }
        public int TruckId { get; set; }
        [Required]
        public string Assignments { get; set; }
        [Required]
        public string LoadingStatus { get; set; }
        [Required]
        public string TruckUtilization { get; set; }
        public string Format {  get; set; }

        public User User { get; set; }
        public Truck Truck { get; set; }

    }
}
