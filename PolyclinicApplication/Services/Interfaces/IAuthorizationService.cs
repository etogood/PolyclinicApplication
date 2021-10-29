using PolyclinicApplication.Data.Models;
using System;

namespace PolyclinicApplication.Services.Interfaces
{
    internal interface IAuthorizationService
    {
        public User Login(string login, string password);

        public bool Register(string firstName, string surname, string patronymic, string insurance, MedicalInsurance medicalInsurance, DateTime dateOfBirth, Address address, Passport passport, UserRole userRole, User user);
    }
}