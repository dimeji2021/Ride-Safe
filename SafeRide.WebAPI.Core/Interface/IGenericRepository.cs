using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeRide.WebAPI.Core.Interface
{
    public interface IGenericRepository<T> where T : class
    {
       Task<T> GetById(string Id);
       Task<IEnumerable<T>> GetAll();
       Task<bool> Create(T model); 
       bool Update(T model);   
       Task<bool> DeleteById(string Id);   



    }
}
