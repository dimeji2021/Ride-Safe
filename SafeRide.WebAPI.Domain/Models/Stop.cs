namespace SafeRide.WebAPI.Domain.Models
{
    public class Stop
    {
      public string Id { get; set; }
      public string Location { get; set; }
      public string RideId { get; set; }
      public Ride Ride { get; set; }
    }
}
