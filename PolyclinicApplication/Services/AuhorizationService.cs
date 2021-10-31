using System;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolyclinicApplication.Data.Models;
using PolyclinicApplication.Exception;
using PolyclinicApplication.Services.Interfaces;

#nullable enable

namespace PolyclinicApplication.Services
{
    class AuhorizationService : IAuthorizationService
    {
        private readonly UserService _userService;
        private readonly IPasswordHasher _passwordHasher;
        public User Login(string login, string password)
        {
            var enteredUser = _userService.GetByLogin(login);

            if (enteredUser == null)
                throw new UserNotFoundException(login);
            
            var passwordVerificationResult =
                _passwordHasher.VerifyHashedPassword(enteredUser.Password, password);

            if (passwordVerificationResult != PasswordVerificationResult.Success)
                throw new InvalidPasswordException();

            return enteredUser;
        }

        public bool Register(string firstName, string surname, string patronymic, string insurance, MedicalInsurance medicalInsurance, DateTime dateOfBirth, Address address, Passport passport, UserRole userRole, User user)
        {
            throw new NotImplementedException();
        }
    }
}
