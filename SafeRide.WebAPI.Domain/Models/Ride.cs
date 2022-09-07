using SafeRide.WebAPI.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Domain.Models
{
    public class Ride : BaseModel
    {
        public int Rating { get; set; }
        [Required]
        public string PickUpLocation { get; set; }
        [Required]
        public string Destination { get; set; } 
        public decimal Payment { get; set; }
        public double DistanceCovered { get; set; }
        [Required]
        public bool Completed { get; set; }

        public Review Reviews { get; set; }

        public Payment Payments { get; set; }

        public string DriverId { get; set; } 
        public Driver Driver { get; set; }

        public string CustomerId { get; set; } 
        public Customer Customer { get; set; }

        public ICollection<Stop> Stops { get; set; }
    }
}
