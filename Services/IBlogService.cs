using System;
using System.Collections.Generic;
using blogResearchNetCore.Models;

namespace blogResearchNetCore.Service
{
    public interface IBlogService: IEntityService<Blog>
    {
        Blog GetByID(Guid id);
    }
}