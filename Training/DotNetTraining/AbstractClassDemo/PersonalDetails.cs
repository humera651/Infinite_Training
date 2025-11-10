using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public sealed class PersonalDetails
    {
        public string Email { get; set; }
        public string LockerNumber { get; set; }
        public string GenericPassword { get; set; }
        public void GetPersonalDetails()
        {
            Console.WriteLine("Enter the Email,Locker Info,Generic Password");
            Email = Console.ReadLine();
            LockerNumber = Console.ReadLine();
            GenericPassword = Console.ReadLine();
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Locker Number: " + LockerNumber);
            Console.WriteLine("Generic Password: "+ GenericPassword);
        }
    }

    //public class EmployeeDetails : PersonalDetails   // compile-time error : PersonalDetails is sealed
    //{
    //}
}
