using SafeRide.WebAPI.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Domain.Models
{
    public class Car : BaseModel
    {
        public string Color { get; set; }
        public string LicenceNumber { get; set; } 

        public string DriverId { get; set; } 
        public Driver Driver { get; set; }
    }
}
