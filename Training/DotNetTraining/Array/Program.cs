using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array declaration and initialization
            int[] numArray = new int[5] { 1, 2, 3, 4, 5 };

            //array declaration
            int[] myArray2 = new int[5];

            //myArray2[0] = 1;
            //myArray2[1] = 2;
            //myArray2[2] = 3;
            //myArray2[3] = 4;
            //myArray2[4] = 5;

            Console.WriteLine($"Enter {myArray2.Length} numbers:");

            //for loop
            for (int i = 0; i < myArray2.Length; i++)
            {
                myArray2[i] =Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n Array Elements are \n ----------------------------------");

            foreach (var item in myArray2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
