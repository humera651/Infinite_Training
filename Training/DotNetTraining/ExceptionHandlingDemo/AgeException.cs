using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    internal class AgeException : ApplicationException
    {
        string message;
        public AgeException(int msg)
        {
            message = msg + "is Invalid age. Age should be 21 to 80";
        }
        public override string ToString()
        {
            return message;
        }
    }
}
