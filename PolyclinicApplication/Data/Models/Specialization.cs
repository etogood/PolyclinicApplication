using System.ComponentModel.DataAnnotations;

namespace PolyclinicApplication.Data.Models
{
    internal class Specialization
    {
        [Key]
        [Required]
        public int SpecializationId { get; set; }

        [Required]
        public string SpecializationName { get; set; }
    }
}