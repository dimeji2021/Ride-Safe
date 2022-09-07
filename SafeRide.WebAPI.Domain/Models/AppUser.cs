using Microsoft.AspNetCore.Identity;
using SafeRide.WebAPI.Domain.Models;

namespace SafeRide.WebAPI.Core.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; } 
        public Driver Driver { get; set; } 
        public ICollection<AppRating> Ratings { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Booking> Bookings { get; set; } 
        public string FullName
        {
            get
            {
                return LastName + " " + FirstName;
            }
        }
    }
}
