using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogNetCore.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public Guid CreateBy { get; set; }
        public Guid UpdateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}