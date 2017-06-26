using System;
using System.Collections.Generic;
using blogResearchNetCore.Models;

namespace blogResearchNetCore.Repositories
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> Get();
        Blog GetByID(Guid id);

        void Update(Guid id);

        void Delete(Guid id);

        Blog Add(Blog course);
    }
}