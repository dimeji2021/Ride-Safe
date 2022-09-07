namespace SafeRide.WebAPI.Domain.Models
{
    public class Stop
    {
      public string Id { get; set; }
      public string Location { get; set; }
      public string BookingId { get; set; }
      public Booking Booking { get; set; }
      public int StopIndex { get; set; }

    }
}
