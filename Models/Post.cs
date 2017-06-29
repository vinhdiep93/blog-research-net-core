using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogResearchNetCore.Models
{
    public class Post : BaseEntity
    {
        public string Title {get; set; }
        public string Summary { get; set; }
        public string Article { get; set; }
        public Guid User_Id { get; set; }
        public datetime Date_Publish { get; set; }
        public string Banner_Image { get; set; }
        public boolean Enable { get; set; }
        public int View { get; set; }
        public Guid Category_Id { get; set; }
        public string Tags { get; set; }
    }
}