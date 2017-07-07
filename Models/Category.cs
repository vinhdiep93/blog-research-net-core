using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogNetCore.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName {get; set; }
        public Status Status { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}