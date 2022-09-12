using Microsoft.Extensions.Logging;
using SafeRide.WebAPI.Domain.Models;
using SafeRide.WebAPI.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeRide.WebAPI.Infrastructure.Repositories
{
    public class BookingRepository : GenericRepository<Booking>, IBookingRepository
    {
        public BookingRepository(SafeRideContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}
