using SafeRide.WebAPI.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Core.Models
{
    public class Driver
    {      
        public int YearsOfExperience { get; set; }
        public string DriverLicense { get; set; }   
               
        public ICollection<Car> Cars { get; set; }
        public ICollection<Booking> Bookings { get; set; }

        [Key]
        public string AppUserId { get; set; }  
        public AppUser AppUser { get; set; }
    }
}
