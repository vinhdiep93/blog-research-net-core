using System;
using System.Collections.Generic;
using BlogNetCore.Models;

namespace BlogNetCore.Services
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