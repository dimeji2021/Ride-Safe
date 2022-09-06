using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Core.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; } 
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; } 
        [Required]
        [StringLength(50)]
        public string Email { get; set; } 
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }       
        public string Phonenumber { get; set; } 
        public string FullName {
            get
            {
                return LastName + " " + FirstName;
            } 
        }
        public bool IsActive { get; set; }
    }
}
