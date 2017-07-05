using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogResearchNetCore.Models
{
    public class Category : BaseEntity
    {
        public string Category_Name {get; set; }
        public Status IsStatus { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}