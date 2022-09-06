using SafeRide.WebAPI.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Core.Models
{
    public class Driver
    {
        [Required]
        [StringLength(100)]
        public string Address { get; set; } 
        public string Gender { get; set; } 
        [Required]
        public int YearsOfExperience { get; set; }
        public string Avatar { get; set; } 
        
        public ICollection<Car> Cars { get; set; }

        public ICollection<Ride> Rides { get; set; }

        [Key]
        public string UserId { get; set; }  
        public AppUser User { get; set; }


    }
}
