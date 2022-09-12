namespace SafeRide.WebAPI.Domain.Models
{
    public class Booking : BaseModel
    {
        public string PickUpLocation { get; set; }
        public string Destination { get; set; } 
        public decimal Payment { get; set; }
        public double DistanceCovered { get; set; }
        public bool Completed { get; set; }

        public Review Reviews { get; set; }
        public Payment Payments { get; set; }

        public string DriverId { get; set; } 
        public Driver Driver { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public ICollection<Stop> Stops { get; set; }
    }
}
