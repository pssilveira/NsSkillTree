using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.Repository
{
    public class Read<T> : IReadRepository<T> where T : class, IEntity
    {
        private readonly DbContext context;

        public Read(DbContext DbContext)
        {
            context = DbContext;
        }

        public async Task<T?> Get(int ID)
        {
            return await context.FindAsync<T>(ID);
        }

        public IQueryable<T> GetAll(Func<T, bool> expression)
        {
            return context.Set<T>().Where(expression).AsQueryable();
        }

        public Task<bool> Has(int ID)
        {
            return context.Set<T>().AnyAsync(x => x.Id == ID);
        }

        public Task<bool> Has(Func<T, bool> expression)
        {
            throw new NotImplementedException();
        }

    }
}
