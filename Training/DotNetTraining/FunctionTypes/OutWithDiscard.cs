using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTypes
{
    internal class OutWithDiscard
    {
        static void Main(string[] args)
        {
            Calculate(10, 5, out int sum, out _, out int product); //out with discard here is for diff
            Console.WriteLine("Sum is : " + sum);
            Console.WriteLine("Product is : " + product);

            Console.ReadLine();
        }

        static void Calculate(int a,int b,out int sum,out int diff,out int product)
        {
            sum = a + b;
            diff = a - b;
            product = a * b;
        }
    }
}
