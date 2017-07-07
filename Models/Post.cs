using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace BlogNetCore.Models
{
    public class Post : BaseEntity
    {
        public string Title {get; set; }
        public string Summary { get; set; }
        public string Article { get; set; }
        public DateTime PublishedDate { get; set; }
        public string BannerImage { get; set; }
        public Status Status { get; set; }
        public int View { get; set; }
        public string Tags { get; set; }

        //public Guid User_Id { get; set; }
        public User User { get; set; }
        //public Guid Category_Id { get; set; }
        public Category Category  { get; set; }
        public ICollection<Comment> Comments { get; set; }
        
    }
}