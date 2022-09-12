namespace SafeRide.WebAPI.Domain.Models
{
    public class AppRating
    {
        public string Id { get; set; }
        public int Rating { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }    
    }
}
