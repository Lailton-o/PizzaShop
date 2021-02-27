using Microsoft.EntityFrameworkCore;
using Pizzaria.Domain.Contracts.Repository.Common;
using Pizzaria.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pizzaria.Infra.Data.Repositories.Common
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly PizzariaContext Db;
        protected readonly DbSet<T> DbSet;

        public Repository(PizzariaContext db)
        {
            Db = db;
            DbSet = Db.Set<T>();
        }

        public async Task<T> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }
        public async Task<T> Single(Expression<Func<T, bool>> predicate)
        {
            return await DbSet.FirstOrDefaultAsync(predicate);
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await DbSet.ToListAsync();
        }
        public async Task<IEnumerable<T>> Search(Expression<Func<T, bool>> predicate)
        {
            return await DbSet.Where(predicate).ToListAsync();
        }
        public void Add(T entity)
        {
            DbSet.Add(entity);
        }
        public void Update(T entity)
        {
            DbSet.Update(entity);
        }
        public void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
