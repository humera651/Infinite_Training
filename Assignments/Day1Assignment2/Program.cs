using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day1Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assignment1 assignment1 = new Assignment1();
            Assignment2 assignment2 = new Assignment2();
            Assignment3 assignment3 = new Assignment3();

            //assignment1.Ass1Method();
            //assignment2.Ass2Method();
            assignment3.Ass3Method();

            ReadLine();
        }
    }
}
