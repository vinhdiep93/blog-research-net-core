using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogResearchNetCore.Models
{
    public class Comment : BaseEntity
    {
        public string Comment {get; set; }
        public Guid Reply_To_Id { get; set; }
        public Status Status { get; set; }

        //public Guid Post_Id { get; set; }
        //public Guid User_Id { get; set; }
        public Post Post { get; set; }
        public User User { get; set; }
    }
}