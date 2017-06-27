using Microsoft.EntityFrameworkCore;

namespace blogResearchNetCore.Models
{
    public class BlogResearchContext: DbContext
    {
        public BlogResearchContext(DbContextOptions options): base(options){}
        public DbSet<Blog> Blogs {get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder){}
    }
}