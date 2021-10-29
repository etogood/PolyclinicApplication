using System.ComponentModel.DataAnnotations;

namespace PolyclinicApplication.Data.Models
{
    internal class Address
    {
        [Key]
        public int AddressId { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string House { get; set; }

        public string Other { get; set; }
    }
}