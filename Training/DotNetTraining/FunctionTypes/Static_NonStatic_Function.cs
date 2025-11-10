using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTypes
{
    internal class Static_NonStatic_Function
    {
        static int x;
        int y;

        void NonStaticMethod()
        {
            Console.WriteLine("Non static Function");
        }
        static void StaticMethod()
        {
            Console.WriteLine("Static Function");
        }
        static void Main(string[] args)
        {
            x = 900;
            Static_NonStatic_Function staticObj = new Static_NonStatic_Function();
            staticObj.y = 500;

            Console.WriteLine("Static variable accessing without object" + x);
            Console.WriteLine("Non static variable accessing through object" + staticObj.y);

            StaticMethod();
            staticObj.NonStaticMethod();

            Console.ReadLine();
        }
    }
}
