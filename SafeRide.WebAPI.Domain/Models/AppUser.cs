using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using SafeRide.WebAPI.Domain.Models;

namespace SafeRide.WebAPI.Core.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; } 
        public string FullName {
            get
            {
                return LastName + " " + FirstName;
            } 
        }
        public bool IsActive { get; set; }
        public AdminUser AdminUser { get; set; }
        public Customer Customer { get; set; }
        public Driver Driver { get; set; }
    }
}
