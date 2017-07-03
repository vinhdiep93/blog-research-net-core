using System;
using System.Collections.Generic;
using blogResearchNetCore.Models;

namespace blogResearchNetCore.Repositories
{
    public interface IGenericRepository<T> where T: BaseEntity
    {
        IEnumerable<T> Get();
        IEnumerable<T> FindByID(System.Linq.Expressions.Expression<Func<T, bool>> predicate);

        void Update(T entity);

        T Delete(T entity);

        T Add(T entity);
    }
}