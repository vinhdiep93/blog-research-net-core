using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogResearchNetCore.Models
{
    public class Category : BaseEntity
    {
        public string Category_Name {get; set; }
        public boolean Enable { get; set; }
    }
}