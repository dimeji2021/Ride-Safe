namespace SafeRide.WebAPI.Core.Models
{
    public class Admin
    {
        public string Qaulification { get; set; } 
        public DateTime CreatedAt { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
