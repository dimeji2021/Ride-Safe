using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SafeRide.WebAPI.Core.Models;
using SafeRide.WebAPI.Domain.Models;

namespace SafeRide.WebAPI.Infrastructure.DataBase
{
    public class SafeRideContext:IdentityDbContext<AppUser>
    {
        public SafeRideContext(DbContextOptions<SafeRideContext> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        public DbSet<AppRating> AppRatings { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Stop> Stops { get; set; }

    }
}
