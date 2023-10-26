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
    public class Write<T> : IWriteRepository<T> where T : class, IEntity
    {
        private readonly DbContext context;

        public Write(DbContext DbContext)
        {
            context = DbContext;
        }

        public async Task<bool> Add(T entity)
        {
            try
            {
                await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public async Task<bool> Remove(Func<T, bool> expression)
        {
            context.Set<T>().RemoveRange(context.Set<T>().Where(expression));
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Remove(int Id)
        {
            var entity = await context.Set<T>().FindAsync(Id);
            if(entity == null)
            {
                return false;
            }
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Remove(T entity)
        {
            context.Set<T>().RemoveRange(context.Set<T>().Where(expression));
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Update(T entity)
        {
            context.Set<T>().RemoveRange(context.Set<T>().Where(expression));
            await context.SaveChangesAsync();
            return true;
        }
    }
}
