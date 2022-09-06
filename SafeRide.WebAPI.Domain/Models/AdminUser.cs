using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Core.Models
{
    public class AdminUser 
    {
        public string Qaulification { get; set; }
        [Key]
        public string UserId { get; set; }
        public AppUser User { get; set; }

    }
}
