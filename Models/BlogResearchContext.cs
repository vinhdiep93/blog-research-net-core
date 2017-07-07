using Microsoft.EntityFrameworkCore;

namespace blogNetCore.Models
{
    public class BlogResearchContext: DbContext
    {
        public BlogResearchContext(DbContextOptions options): base(options){}
        public DbSet<Blog> Blogs {get;set;}
        public DbSet<Category> Categorys {get;set;}
        public DbSet<Comment> Comments {get;set;}
        public DbSet<Menu> Menus {get;set;}
        public DbSet<Post> Posts {get;set;}
        public DbSet<Series> Series {get;set;}
        public DbSet<User_Profile> User_Profiles {get;set;}
        public DbSet<User> Users {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){}
    }
}