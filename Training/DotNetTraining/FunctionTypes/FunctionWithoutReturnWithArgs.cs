using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTypes
{
    internal class FunctionWithoutReturnWithArgs
    {
        static void Main(string[] args)
        {
            Addition(10, 20); //direct hard coded the values while calling the function
            int a, b;
            Console.WriteLine("Enter the value for a & b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Addition(a, b);

            Console.ReadLine();
        }

        static void Addition(int x,int y)
        {
            int res;
            res = x + y;
            Console.WriteLine("x + y = " + res);
        }
    }
}
