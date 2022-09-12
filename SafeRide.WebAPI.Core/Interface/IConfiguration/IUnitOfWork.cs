using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeRide.WebAPI.Core.Interface.IConfiguration
{
    public interface IUnitOfWork
    {
        IAppRatingRepository AppRatings { get; }
        IAppUserRepository AppUsers { get; }
        IBookingRepository Bookings { get; }
        ICarRepository Cars { get; }
        IDriverRepository Drivers { get; }
        IPaymentRepository payments { get; }
        IReviewRepository reviews { get; }   
        IStopRepository stops { get; }


        Task CompleteAsync();


    }
}
