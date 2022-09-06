using SafeRide.WebAPI.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Domain.Models
{
    public class Reviews
    {
        [Key]
        public string ReviewId { get; set; } 
        [Required]
        public string Content { get; set; }
        public DateTime Created { get; set; }

        public string RideId { get; set; }
        public Ride? Cars { get; set; }

        public string CustomersId { get; set; }
        public Customer? Customer { get; set; }

    }
}
