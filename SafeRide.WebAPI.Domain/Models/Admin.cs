namespace SafeRide.WebAPI.Core.Models
{
    public class Admin : User
    {
        public string Qaulification { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

    }
}
