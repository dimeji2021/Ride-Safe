using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Domain.Models
{
    public class Payment : BaseModel
    {
        [Key]
        public decimal Amount { get; set; }
        public string PaymentType { get; set; }

        public string RideId { get; set; }
        public Ride Ride { get; set; }
    }
}
