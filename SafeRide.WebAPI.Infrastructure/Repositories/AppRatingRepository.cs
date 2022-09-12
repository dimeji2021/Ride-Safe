global using SafeRide.WebAPI.Core.Interface;
using Microsoft.Extensions.Logging;
using SafeRide.WebAPI.Domain.Models;
using SafeRide.WebAPI.Infrastructure.DataBase;

namespace SafeRide.WebAPI.Infrastructure.Repositories
{
    public class AppRatingRepository : GenericRepository<AppRating>, IAppRatingRepository
    {
        public AppRatingRepository(SafeRideContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}
