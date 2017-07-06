using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogResearchNetCore.Models
{
    public class Blog : AuditableEntity<Guid>
    {
        public string Title {get; set; }
    }
}
