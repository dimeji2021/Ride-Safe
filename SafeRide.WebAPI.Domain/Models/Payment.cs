using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Domain.Models
{
    public class Payment : BaseModel
    {
        [Key]
        public decimal Amount { get; set; }
        public string PaymentType { get; set; }

        public string BookingId { get; set; }
        public Booking Booking { get; set; }
    }
}
