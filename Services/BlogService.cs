using System;
using System.Collections.Generic;
using BlogNetCore.Models;
using BlogNetCore.Repositories;

namespace BlogNetCore.Services
{
    public class BlogService : IBlogService
    {
        private IBlogRepository _blogRepository;
        public BlogService(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
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
            return _blogRepository.Get();
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