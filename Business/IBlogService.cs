using System;
using System.Collections.Generic;
using blogResearchNetCore.Models;

namespace blogResearchNetCore.Business
{
    public interface IBlogService
    {
        IEnumerable<Blog> Get();
        Blog GetByID(Guid id);

        void Update(Guid id);

        void Delete(Guid id);

        Blog Add(Blog course);
    }
}