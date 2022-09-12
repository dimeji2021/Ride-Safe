using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SafeRide.WebAPI.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeRide.WebAPI.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected SafeRideContext _context;
       
        protected DbSet<T> _dbset;
       
        private readonly ILogger _logger;

        public GenericRepository(SafeRideContext context, ILogger logger )
        {
            _context = context;
            _dbset = context.Set<T>();
            _logger = logger;
        }

        public async Task<bool> Create(T model)
        {
             _dbset.Add( model );
             return true;
        }

        public async  Task<bool> DeleteById(string Id)
        {
            var exist = await _dbset.FindAsync(Id);
            if (exist != null)
            {
                _dbset.Remove(exist);
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
          return await  _dbset.ToListAsync();
        }

        public async Task<T> GetById(string Id)
        {
 
            return await _dbset.FindAsync(Id);
        }

        public  bool Update(T modelChange)
        {
            var model=  _dbset.Attach(modelChange);
            model.State=EntityState.Modified;
            return true;
        }
    }
}
