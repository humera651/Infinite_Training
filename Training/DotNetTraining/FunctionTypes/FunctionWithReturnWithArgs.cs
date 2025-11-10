using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTypes
{
    internal class FunctionWithReturnWithArgs
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the value for a and b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int result = Addition(a, b);
            Console.WriteLine("Result is: " +result);

            Console.ReadLine();
        }

        static int Addition(int x,int y)
        {
            int res;
            res = x + y;
            return res;
        }
    }
}
