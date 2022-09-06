using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Domain.Models
{
    public class Review : BaseModel
    {
        [Required]
        public string Content { get; set; }

        public string RideId { get; set; }
        public Ride Ride { get; set; }

        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
