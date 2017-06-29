using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogResearchNetCore.Models
{
    public class Comment : BaseEntity
    {
        public Guid Post_Id { get; set; }
        public Guid User_Id { get; set; }
        public string Comment {get; set; }
        public Guid Reply_To_Id { get; set; }
        public boolean Enable { get; set; }
    }
}