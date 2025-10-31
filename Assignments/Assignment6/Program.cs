using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age, showTime;

            Console.WriteLine("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter show time (24-hr format): ");
            showTime = Convert.ToInt32(Console.ReadLine());

            if (age < 12)
                Console.WriteLine("Ticket price: Rs 150");
            else if (age >= 12 && showTime < 6)
                Console.WriteLine("Ticket price: Rs 250");
            else if (age >= 12 && showTime > 6)
                Console.WriteLine("Ticket price: Rs 300");

            Console.ReadLine();
        }
    }
}
