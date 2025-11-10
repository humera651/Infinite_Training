using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo
{
    class Customer
    {
        //Auto-Implemented Properties
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine("Customer ID: " + CustomerID);
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Phone Number: " + PhoneNumber);
        }
    }
    internal class AutoPropertyDemo
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter the customer id,name,phone number,email");
            customer.CustomerID = Convert.ToInt32(Console.ReadLine());
            customer.CustomerName = Console.ReadLine();
            customer.PhoneNumber = Console.ReadLine();
            customer.Email = Console.ReadLine();

            customer.DisplayCustomerInfo();

            Console.ReadKey();
        }
    }
}
