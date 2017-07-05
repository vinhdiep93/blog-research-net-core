using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogResearchNetCore.Models
{
    public enum Status
    {
        Waiting,
        Active,
        DeActive,
        Deleted
    };

    public enum UserStatus{
        Waiting,
        Active,
        DeActive,
        Banned
    } 
    
}