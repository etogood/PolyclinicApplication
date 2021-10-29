using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyclinicApplication.Data.Models
{
    class MedicalInsurance
    {
        [Key]
        public int MedicalInsuranceId { get; set; }

        public int MedicalInsuranceNumber { get; set; }

        public DateTime DateOfIssue { get; set; }

        public string InsuranceCompanyName { get; set; }
    }
}
