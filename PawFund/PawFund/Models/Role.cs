using System.ComponentModel.DataAnnotations.Schema;

namespace PawFund.Models
{
    [Table(name: "Role")]

    public class Role
    {
        public int RoleId { get; set; } 
        public string Name { get; set; }
    }
}
