using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password;
            Console.WriteLine("Enter password: ");
            password = Console.ReadLine();

            if(password.Length < 6)
                Console.WriteLine("Password strength: Weak");
            else if(password.Length >= 6 && password.Length <= 10)
                Console.WriteLine("Password strength: Medium");
            else if(password.Length > 10)
                Console.WriteLine("Password strength: Strong");
            Console.ReadLine();
        }
    }
}
