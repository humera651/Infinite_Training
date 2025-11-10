using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTypes
{
    internal class CallByValueRef
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 10;
            b = 20;
            Console.WriteLine("\nCalling By Value Demo");
            Console.WriteLine("Value of A before calling MethodValue " + a);
            MethodValue(a);
            Console.WriteLine("Value of A after calling MethodValue " + a);

            Console.WriteLine("\nCalling By Reference Demo");
            Console.WriteLine("Value of B before calling MethodRef " + b);
            MethodRef(ref b);
            Console.WriteLine("Value of B after calling MethodRef " + b);

            Console.ReadLine();
        }

        static void MethodValue(int a)
        {
            a = a + 10;
            Console.WriteLine("Value of A in MethodValue " + a);
        }
        static void MethodRef(ref int b)
        {
            b = b + 10;
            Console.WriteLine("Value of B in MethodRef " + b);
        }
    }
}
