using System.ComponentModel.DataAnnotations;

namespace SafeRide.WebAPI.Domain.Models
{
    public class Image
    {
      [Key]
      public string ImageId { get; set; }
      public string PhotoPath { get; set; } 

      public string CarId { get; set; } 
      public Car? Cars { get; set; }

    }
}
