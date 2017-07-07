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
                    Title = "Title 1"
                },
                new Blog
                {
                    Title = "Title 2"
                },
                new Blog
                {
                    Title = "Title 3"
                });
            };
            context.SaveChanges();
        }
    }
}