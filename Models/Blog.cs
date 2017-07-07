using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogNetCore.Models
{
    public class Blog
    {
        public Guid Id { get; set; }
        public string Title {get; set; }
    }
}
