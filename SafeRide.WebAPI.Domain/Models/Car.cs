using SafeRide.WebAPI.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Domain.Models
{
    public class Car
    {
        [Key]
        public string CarId { get; set; } 
        public string Color { get; set; } 
        public string FeaturedImage { get; set; }
        [Required]
        public string CarPlateNumber { get; set; }
        [Required]
        public string LicenceNumber { get; set; } 

        public string DriverId { get; set; } 
        public Drivers? Driver { get; set; }

        public ICollection<Image> Images { get; set; }  
    }
}
