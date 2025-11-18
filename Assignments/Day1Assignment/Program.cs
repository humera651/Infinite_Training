using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day1Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ass 1
            Student student = new Student()
            {
                Name = "Humera",
                Age = 24,
            };

            student.DisplayDetils();

            //Ass 2
            string str1 = "Hello";
            WriteLine($"Hello isUpper : {str1.IsUpper()}");
            string str2 = "HELLO";
            WriteLine($"HELLO isUpper : {str2.IsUpper()}");

            //Ass 3
            List<int> nums = new List<int>() { 2, 3, 4 };
            WriteLine(nums.SumOfSquares());

            ReadLine();
        }
    }
}
