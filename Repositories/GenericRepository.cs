using System;
using System.Collections.Generic;
using System.Linq;
using blogResearchNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace blogResearchNetCore.Repositories
{
    public abstract class GenericRepository<T>: IGenericRepository<T> where T:BaseEntity
    {
        protected DbContext _entities;
        protected readonly DbSet<T> _dbSet;
        public GenericRepository(DbContext context)
        {
            _entities = context;
            _dbSet = context.Set<T>();
        }

        public virtual T Add(T entity)
        {
            return _dbSet.Add(entity).Entity;
        }

        public virtual T Delete(T entity)
        {
            return _dbSet.Remove(entity).Entity;
        }

        public virtual IEnumerable<T> Get()
        {
            return _dbSet.AsEnumerable<T>();
        }

        public IEnumerable<T> FindByID(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> entity = _dbSet.Where(predicate).AsEnumerable();
            return entity;
        }

        public void Update(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }
    }
}