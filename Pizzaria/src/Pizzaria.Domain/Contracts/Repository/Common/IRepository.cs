using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Contracts.Repository.Common
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(Guid id);
        Task<T> Single(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> Search(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
