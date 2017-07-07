using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogNetCore.Models
{
    public enum Status
    {
        Waiting,
        Active,
        InActive,
        Deleted
    };

    public enum UserStatus{
        Waiting,
        Active,
        InActive,
        Banned
    } 
    
}