using Business.Entities;
using System.Linq.Expressions;

namespace Infrastructure.Database
{
    public interface IReadRepository<T> where T : class, IEntity
    {
        IQueryable<T> GetAll(Func<T, bool> expression);
        Task<T?> Get(int ID);
        Task<bool> Has(int ID);
        Task<bool> Has(Func<T, bool> expression);
    }
}
