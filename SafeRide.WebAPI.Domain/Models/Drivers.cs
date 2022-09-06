using SafeRide.WebAPI.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Core.Models
{
    public class Drivers
    {
        [Required]
        [StringLength(100)]
        public string Address { get; set; } 
        public string Gender { get; set; } 
        [Required]
        public int YearsOfExperience { get; set; }
        public string Avatar { get; set; } 
        public DateTime CreatedAt { get; set; }
        
        public ICollection<Car> cars { get; set; }

        public ICollection<Ride> Rides { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
