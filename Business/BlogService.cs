using System;
using System.Collections.Generic;
using blogResearchNetCore.Models;
using blogResearchNetCore.Repositories;

namespace blogResearchNetCore.Business
{
    public class BlogService : IBlogService
    {
        private IBlogRepository _blogRepository;
        public BlogService(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public Blog Add(Blog course)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Blog> Get()
        {
            return _blogRepository.Get();
        }

        public Blog GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}