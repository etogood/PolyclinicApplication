using System.ComponentModel.DataAnnotations;

namespace PolyclinicApplication.Data.Models
{
    internal class UserRole
    {
        [Key]
        public int UserRoleId { get; set; }

        [Required]
        public string UserRoleName { get; set; }
    }
}