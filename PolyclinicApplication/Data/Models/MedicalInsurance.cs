using System;
using System.ComponentModel.DataAnnotations;

namespace PolyclinicApplication.Data.Models
{
    public class MedicalInsurance
    {
        [Key]
        public int MedicalInsuranceId { get; set; }

        public int MedicalInsuranceNumber { get; set; }

        public DateTime DateOfIssue { get; set; }

        public string InsuranceCompanyName { get; set; }
    }
}