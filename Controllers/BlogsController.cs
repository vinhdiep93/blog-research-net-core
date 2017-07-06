using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogResearchNetCore.Business;
using blogResearchNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace blogResearchNetCore.Controllers
{
    [Route("api/[controller]")]
    public class BlogsController : Controller
    {
        private IBlogService _blogService;
        public BlogsController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        // GET api/blogs
        [HttpGet]
        public IEnumerable<Blog> Get()
        {
            var listBlog = _blogService.Get();
            return listBlog.ToList();
        }

        // GET api/blogs/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "blogs";
        }

        // POST api/blogs
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/blogs/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/blogs/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
