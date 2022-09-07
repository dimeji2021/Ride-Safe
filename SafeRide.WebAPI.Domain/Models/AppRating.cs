using SafeRide.WebAPI.Core.Models;

namespace SafeRide.WebAPI.Domain.Models
{
    public class AppRating
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }    
    }
}
