using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Core.Models
{
    public class AdminUser 
    {
        public string Qaulification { get; set; }
        [Key]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
