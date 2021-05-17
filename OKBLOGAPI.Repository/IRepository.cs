using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKBLOGAPI.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T> RetrieveAync(Guid id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<IEnumerable<T>> RetrieveAllAsync();
    }
}
