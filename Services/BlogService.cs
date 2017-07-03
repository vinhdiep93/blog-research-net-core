using System;
using System.Collections.Generic;
using blogResearchNetCore.Models;
using blogResearchNetCore.Repositories;

namespace blogResearchNetCore.Service
{
    public class BlogService : EntityService<Blog>,IBlogService
    {
        IUnitOfWork _unitOfWork;
        IBlogRepository _blogRepository;
        public BlogService(IUnitOfWork unitOfWork,IBlogRepository blogRepository):base(unitOfWork,blogRepository)
        {
            _unitOfWork = unitOfWork;
            _blogRepository = blogRepository;
        }

        public Blog GetByID(Guid id)
        {
            return _blogRepository.GetById(id);
        }
    }
}