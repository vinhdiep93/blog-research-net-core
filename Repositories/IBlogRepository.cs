using System;
using System.Collections.Generic;
using blogNetCore.Models;

namespace blogNetCore.Repositories
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> Get();
        Blog GetByID(Guid id);

        void Update(Blog blog);

        void Delete(Guid id);

        Blog Add(Blog blog);
    }
}