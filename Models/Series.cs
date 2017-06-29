using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogResearchNetCore.Models
{
    public class Series : BaseEntity
    {
        public Guid Post_Id { get; set; }
        public string Series_Name {get; set; }
        public boolean Enable { get; set; }
    }
}