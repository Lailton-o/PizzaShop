using Microsoft.EntityFrameworkCore;
using PizzaShop.Domain.Contracts.Repository.Common;
using PizzaShop.Infra.Data.Context;
using PizzaShop.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PizzaShop.Infra.Data.Repositories.Common
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly EfContext Db;
        protected readonly DbSet<T> DbSet;

        public Repository(EfContext db)
        {
            Db = db;
            DbSet = Db.Set<T>();
        }

        public T GetbyId(Guid id)
        {
            throw new NotImplementedException();
        }

        public T Single(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Search(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        public int Add(T entity)
        {
            throw new NotImplementedException();
        }
        public int Update(T entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
