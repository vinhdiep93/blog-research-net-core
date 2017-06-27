using System;
using System.Collections.Generic;
using System.Linq;
using blogResearchNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace blogResearchNetCore.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private BlogResearchContext context;
        public BlogRepository(BlogResearchContext context)
        {
            this.context = context;
        }
        public Blog Add(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Blog> Get()
        {
            return context.Blogs.AsNoTracking().ToList();
        }

        public Blog GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}