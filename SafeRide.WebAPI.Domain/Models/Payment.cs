using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Domain.Models
{
    public class Payment
    {
        [Key]
        public string PaymentId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentType { get; set; }
        public DateTime TransactionDate { get; set; }

        public string RideId { get; set; }
        public Ride Ride { get; set; }
    }
}
