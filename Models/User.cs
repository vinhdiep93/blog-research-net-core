using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogResearchNetCore.Models
{
    public class User : BaseEntity
    {
        public string Username {get; set; }
        public string Password { get; set; }
        public boolean Active { get; set; }
    }
}