using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Domain.Models
{
    public class Review : BaseModel
    {
        [Required]
        public string Content { get; set; }

        public string BookingId { get; set; }
        public Booking Booking { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
