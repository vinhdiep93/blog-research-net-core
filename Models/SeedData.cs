using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System;

namespace blogResearchNetCore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            BlogResearchContext context = app.ApplicationServices.GetRequiredService<BlogResearchContext>();
            if (!context.Blogs.Any())
            {
                context.Blogs.AddRange(
                new Blog
                {
                    Id = Guid.NewGuid(),
                    Title = "Title 1"
                },
                new Blog
                {
                    Id = Guid.NewGuid(),
                    Title = "Title 1"
                },
                new Blog
                {
                    Id = Guid.NewGuid(),
                    Title = "Title 1"
                });
            };
            context.SaveChanges();
        }
    }
}