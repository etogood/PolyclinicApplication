using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace PolyclinicApplication.Exception
{
    [Serializable]
    internal class UserNotFoundException : System.Exception
    {
        public UserNotFoundException()
        {
            
        }

        public UserNotFoundException(string? message) : base(message)
        {
            
        }
    }
}
