using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OverloadingDemo overloadingDemo = new OverloadingDemo();
            overloadingDemo.GetEmployeeInfo(101);
            overloadingDemo.GetEmployeeInfo("Humera");
            overloadingDemo.GetEmployeeInfo(102, "Jasmine");
            overloadingDemo.GetEmployeeInfo("Euru", 103);

            Console.ReadLine();
        }
    }
}
