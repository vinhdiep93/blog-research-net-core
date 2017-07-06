using System;
using System.Collections.Generic;
using blogResearchNetCore.Models;

namespace blogResearchNetCore.Repositories
{
    public interface IBlogRepository : IGenericRepository<Blog>
    {
        Blog GetById(Guid id);
    }
}