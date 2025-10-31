using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            float avg_score = 23.45f;
            double precision_value = 11223.4422;
            decimal money_amount = 121733.2311m;
            char grade = 'A';
            string message = "hello , demo";

            Console.WriteLine("Num1 value is" + num1);
            Console.WriteLine("Num2 value is {0}", num2);
            Console.WriteLine($"Average score is {avg_score}");

            Console.WriteLine($"Precision value is {precision_value} \nMoney amount is {money_amount} \nGrade is {grade} \n");
            Console.WriteLine($"Message is {message}");

            Console.ReadLine();

        }
    }
}
