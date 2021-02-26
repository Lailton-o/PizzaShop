using PizzaShop.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PizzaShop.Domain.Contracts.Repository.Common
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        T GetbyId(Guid id);
        T Single(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAll();
        IEnumerable<T> Search(Expression<Func<T, bool>> predicate);
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
    }
}
