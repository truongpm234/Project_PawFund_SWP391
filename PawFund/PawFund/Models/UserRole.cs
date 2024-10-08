﻿using System.ComponentModel.DataAnnotations.Schema;

namespace PawFund.Models
{
    [Table(name: "UserRole")]
    public class UserRole
    {
        //public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        // Navigation properties
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
