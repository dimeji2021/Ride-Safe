using SafeRide.WebAPI.Core.Models;

namespace SafeRide.WebAPI.Domain.Models
{
    public class Customer : User
    {
        public string Address { get; set; } 
        public DateTime CreatedAt { get; set; }

        public ICollection<Ride> Rides { get; set; }  
        
        public ICollection<Reviews> Reviews { get; set; }

    }
}
