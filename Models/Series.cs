using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BlogNetCore.Models
{
    public class Series : BaseEntity
    {
        public string SeriesName {get; set; }
        public Status Status { get; set; }
        public ICollection<Post> Posts { get; set; }

    }
}