using Microsoft.Azure.NotificationHubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolyclinicApplication.Data.Models;
using PolyclinicApplication.Services;

namespace PolyclinicApplication.Stores
{
    class Authenticator : IAuthenticator
    {
        private readonly AuthorizationService _authorizationService;
        public static User CurrentUser { get; private set; }
        public static bool IsLogIn => CurrentUser != null;

        public Authenticator()
        {
            _authorizationService = new AuthorizationService();
        }

        public void Login(string username, string password) => CurrentUser = _authorizationService.Login(username, password);
        
        public RegistrationResult Register(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
