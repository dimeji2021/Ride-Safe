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
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(SafeRideContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}
