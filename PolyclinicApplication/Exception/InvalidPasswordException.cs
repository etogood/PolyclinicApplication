using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace PolyclinicApplication.Exception
{
    internal class InvalidPasswordException : System.Exception
    {
        public InvalidPasswordException()
        {
            
        }

        public InvalidPasswordException(string? message) : base(message)
        {
            
        }
    }
}
