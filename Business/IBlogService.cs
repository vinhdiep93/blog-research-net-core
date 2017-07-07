using System;
using System.Collections.Generic;
using blogNetCore.Models;

namespace blogNetCore.Business
{
    public interface IBlogService
    {
        IEnumerable<Blog> Get();
        Blog GetByID(Guid id);

        void Update(Blog blog);

        void Delete(Guid id);

        Blog Add(Blog blog);
    }
}