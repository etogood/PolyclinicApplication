using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.NotificationHubs;

namespace PolyclinicApplication.Stores
{
    interface IAuthenticator
    {
        void Login(string username, string password);

        RegistrationResult Register(string username, string password);
    }
}
