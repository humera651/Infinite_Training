using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTypes
{
    internal class ParamsDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfIntegers(1,56,3,46,67));
            Console.WriteLine(SumOfIntegers(56,64,34));
            Console.WriteLine(SumOfIntegers(87,54));

            Console.ReadLine();
        }

        static int SumOfIntegers(params int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}
