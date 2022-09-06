using SafeRide.WebAPI.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Core.Models
{
    public class Drivers : User
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

    }
}
