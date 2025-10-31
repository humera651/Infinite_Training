using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double service,salary;

            Console.WriteLine("Enter your service years");
            service = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your salary");
            salary = Convert.ToDouble(Console.ReadLine());

            if(service > 10)
                Console.WriteLine("Your final salary is " + (salary + (salary * 20 / 100)));
            else if(service>5 && service<=10)
                Console.WriteLine("Your final salary is " + (salary + (salary * 10 / 100)));
            else if(service<5)
                Console.WriteLine("Your final salary is " + (salary + (salary * 5 / 100)));
            else
                Console.WriteLine("Your final salary is " + salary);
            Console.ReadLine();
        }
    }
}
