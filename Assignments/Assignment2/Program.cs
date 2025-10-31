using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            double marks;

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your marks");
            marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 90)
                Console.WriteLine(name + " your grade is A+");
            else if (marks <= 89 && marks >= 80)
                Console.WriteLine(name + " your grade is A");
            else if (marks <= 79 && marks >= 70)
                Console.WriteLine(name + " your grade is B");
            else if (marks <= 69 && marks >= 60)
                Console.WriteLine(name + " your grade is C");
            else if (marks <= 59 && marks >= 50)
                Console.WriteLine(name + " your grade is D");
            else
                Console.WriteLine(name + " you are failed");
            Console.ReadLine();
        }
    }
}
