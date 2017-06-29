using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogResearchNetCore.Models
{
    public class User_Profile : BaseEntity
    {
        public Guid User_Id { get; set; }
        public string FirstName {get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }
    }
}