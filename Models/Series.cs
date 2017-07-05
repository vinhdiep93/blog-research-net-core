using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogResearchNetCore.Models
{
    public class Series : BaseEntity
    {
        public string Series_Name {get; set; }
        public Status Status { get; set; }
        public ICollection<Post> Posts { get; set; }

    }
}