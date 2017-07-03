using System;
using System.Collections.Generic;
using System.Linq;
using blogResearchNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace blogResearchNetCore.Repositories
{
    public class BlogRepository : GenericRepository<Blog>,IBlogRepository
    {
        public BlogRepository(DbContext context) : base(context)
        {}

        public override IEnumerable<Blog> Get()
        {
            return _entities.Set<Blog>().AsNoTracking().ToList();
        }

        public Blog GetById(Guid id)
        {
            return _dbSet.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}