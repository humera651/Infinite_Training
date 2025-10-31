using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lightColor;
            Console.WriteLine("Enter light color: ");
            lightColor = Console.ReadLine();

            if (lightColor == "Red")
                Console.WriteLine("Action: Stop");
            else if(lightColor == "Yellow")
                Console.WriteLine("Action: Get Ready");
            else
                Console.WriteLine("Action: Go");

            Console.ReadLine();
        }
    }
}
