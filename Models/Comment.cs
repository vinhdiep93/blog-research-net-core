using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogNetCore.Models
{
    public class Comment : BaseEntity
    {
        public string Content {get; set; }
        public Guid ReplyToPostId { get; set; }
        public Status Status { get; set; }

        //public Guid Post_Id { get; set; }
        //public Guid User_Id { get; set; }
        public Post Post { get; set; }
        public User User { get; set; }
    }
}