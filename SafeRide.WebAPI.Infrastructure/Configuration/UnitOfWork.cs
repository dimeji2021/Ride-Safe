using Microsoft.Extensions.Logging;
using SafeRide.WebAPI.Core.Interface.IConfiguration;
using SafeRide.WebAPI.Infrastructure.DataBase;
using SafeRide.WebAPI.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeRide.WebAPI.Infrastructure.Configuration
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly SafeRideContext _safeRideContext;
        private readonly ILogger _logger;

        public IAppRatingRepository AppRatings { get; private set; }

        public IAppUserRepository AppUsers { get; private set; }

        public IBookingRepository Bookings { get; private set; }

        public ICarRepository Cars { get; private set; }

        public IDriverRepository Drivers { get; private set; }

        public IPaymentRepository payments { get; private set; }

        public IReviewRepository reviews { get; private set; }

        public IStopRepository stops { get; private set; }

        public UnitOfWork(SafeRideContext safeRideContext, ILoggerFactory logger)
        {
            _safeRideContext = safeRideContext;
            _logger = logger.CreateLogger("log");
            AppRatings = new AppRatingRepository(_safeRideContext, _logger);
            AppUsers = new AppUserRepository(_safeRideContext, _logger);
            Bookings = new BookingRepository(_safeRideContext, _logger);
            Cars = new CarRepository(_safeRideContext, _logger);
            Drivers = new DriverRepository(_safeRideContext, _logger);  
            payments = new PaymentRepository(_safeRideContext, _logger);
            reviews = new ReviewRepository(_safeRideContext, _logger);
            stops = new StopRepository(_safeRideContext, _logger);

        }
        public async Task CompleteAsync()
        {
           await _safeRideContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _safeRideContext.Dispose();
        }
    }
}
