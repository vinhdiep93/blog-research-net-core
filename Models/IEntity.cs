using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogResearchNetCore.Models
{
    public interface IEntity<T>
    {
        T Id {get;set;}
    }
}
