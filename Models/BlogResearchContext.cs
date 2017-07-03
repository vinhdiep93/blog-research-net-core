using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Data;
using System.Threading;
using System;

namespace blogResearchNetCore.Models
{
    public class BlogResearchContext: DbContext
    {
        public BlogResearchContext(DbContextOptions options): base(options){}
        public DbSet<Blog> Blogs {get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder){}
        public override int SaveChanges(){
            var modifiedEntries = ChangeTracker.Entries().Where(x => x.Entity is IAuditableEntity
                && (x.State ==  EntityState.Added ||  x.State == EntityState.Modified));

            foreach(var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if(entity != null)
                {
                    string identityName = "admin";
                    DateTime now = DateTime.UtcNow;
 
                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedDate = now;
                    }
                    else {
                        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;                   
                    }
    
                    entity.UpdatedBy = identityName;
                    entity.UpdatedDate = now;
                }
            }

            return base.SaveChanges();
        }
    }
}