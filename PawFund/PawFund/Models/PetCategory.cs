﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PawFund.Models
{
    [Table(name: "PetCategory")]

    public class PetCategory
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Category { get; set; }
    }
}
