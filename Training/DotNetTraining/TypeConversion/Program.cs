using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            double value = num; //implicit type conversion
            Console.WriteLine($"num = {num} \nvalue = {value}");

            double pi = 3.14;
            int intPi = (int)pi; //explicit type conversion

            /*
             * Converting value type to object type is called as Boxing
             * Converting object type to value type is called as Unboxing
             */

            object obj = num; //Boxing
            int myVal = (int)obj; //Unboxing

            //value type vs reference type
            int a = 100;
            int b = a; //copying the data

            Console.WriteLine($"A value is {a} \t b value is {b}");
            b = 88;
            Console.WriteLine($"A value is {a} \t b value is {b}");


            string[] names = { "geetha" ,"samantha"};
            string[] copynames = names;
            Console.WriteLine($"names[0] {names[0]} \t names[1] {names[1]}");

            copynames[0] = "vijay";
            Console.WriteLine($"names[0] {names[0]} \t names[1] {names[1]}");

            Console.ReadLine();
        }
    }
}
