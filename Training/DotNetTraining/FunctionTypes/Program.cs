using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition();
            Console.ReadLine();     
        }
        //Function without return & without arguments
        static void Addition()
        {
            int num1, num2, sum;
            Console.WriteLine("Enter First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("Sum of given numbers are: " + sum);

        }
    }
}
