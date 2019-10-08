using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TodoApp.Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T: class
    {
        Task InsertAsync(T entity);
        Task DeleteAsync(Guid id);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task<T> GetAsync(Guid id);
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAllAsync();
    }
}
