using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the option 1.Add \n2.Subtract \n3.Multiplication \n4.Divide");
            int choice = Convert.ToInt32(Console.ReadLine());
            double num1, num2;
            Console.WriteLine("Enter first number");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition is : " + (num1+num2));
                    break;
                case 2:
                    Console.WriteLine("Subtraction is : " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication is : " + (num1*num2));
                    break;
                case 4:
                    if (num2 != 0)
                        Console.WriteLine("Division is : " + (num1 / num2));
                    else
                        Console.WriteLine("Error:Division by zero is not allowed.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
