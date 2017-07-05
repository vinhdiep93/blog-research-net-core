using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogResearchNetCore.Models
{
    public class Menu : BaseEntity
    {
        public string Title {get; set; }
        public string url { get; set; }
        public string icon_url { get; set; }
        public Status IsStatus { get; set; }
    }
}