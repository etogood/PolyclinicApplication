using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolyclinicApplication.Data.Models;
using PolyclinicApplication.Services.Interfaces;

namespace PolyclinicApplication.Services
{
    class AuhorizationService : IAuthorizationService
    {
        public User Login(string login, string password)
        {
            throw new NotImplementedException();
        }

        public bool Register(string firstName, string surname, string patronymic, string insurance, MedicalInsurance medicalInsurance, DateTime dateOfBirth, Address address, Passport passport, UserRole userRole, User user)
        {
            throw new NotImplementedException();
        }
    }
}
