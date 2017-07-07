using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogNetCore.Models
{
    public class User : BaseEntity
    {
        public string Username {get; set; }
        public string Password { get; set; }
        public UserStatus Status { get; set; }

        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<User_Profile> UserProfiles { get; set; }
    }
}