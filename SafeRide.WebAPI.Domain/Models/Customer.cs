using SafeRide.WebAPI.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Domain.Models
{
    public class Customer
    {
        public string Address { get; set; } 

        public ICollection<Ride> Rides { get; set; }          
        public ICollection<Review> Reviews { get; set; }

        [Key]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
