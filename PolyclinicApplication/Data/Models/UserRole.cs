using System.ComponentModel.DataAnnotations;

namespace PolyclinicApplication.Data.Models
{
    public class UserRole
    {
        [Key]
        public int UserRoleId { get; set; }

        [Required]
        public string UserRoleName { get; set; }
    }
}