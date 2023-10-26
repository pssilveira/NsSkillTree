using Business.Entities;
using System.Linq.Expressions;

namespace Infrastructure.Database
{
    public interface IWriteRepository<T> where T : class, IEntity
    {
        Task<bool> Add(T entity);
        Task<bool> Remove(Func<T, bool> expression);
        Task<bool> Remove(int Id);
        Task<bool> Remove(T entity);
        Task<bool> Update(T entity);
    }
}
