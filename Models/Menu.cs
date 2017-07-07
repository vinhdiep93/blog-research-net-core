using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogNetCore.Models
{
    public class Menu : BaseEntity
    {
        public string Title {get; set; }
        public string Url { get; set; }
        public string IconUrl { get; set; }
        public Status Status { get; set; }
    }
}