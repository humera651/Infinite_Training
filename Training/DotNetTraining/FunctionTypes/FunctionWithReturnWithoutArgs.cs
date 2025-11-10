using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTypes
{
    internal class FunctionWithReturnWithoutArgs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Function with return and without args\n");
            //Console.WriteLine("Addition is : " + Addition());
            int result = Addition();
            Console.WriteLine("Result is " + result);
            Console.ReadLine();
        }
        //function with return and without args
        static int Addition()
        {
            int num1, num2, sum;
            Console.WriteLine("Enter First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;
            return sum;

        }
    }
}
