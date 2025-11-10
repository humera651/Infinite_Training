using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare the array of four elements
            int[][] jaggedArray = new int[4][];

            //Initialize the elements
            jaggedArray[0] = new int[2] {3,4};
            jaggedArray[1] = new int[4] { 5, 4, 2, 2 };
            jaggedArray[2] = new int[6] { 1, 3, 2, 4, 5, 7 };
            jaggedArray[3] = new int[3] { 2, 3, 4 };

            //Display the array elements
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Element({0})",i+1);
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

            //Jagged array of string

            //Declare the array of four elements
            string[][] Members = new string[4][]
            {
                new string[] { "Rocky","Sam","Alex"},
                new string[] { "Peter","Sonia","Preity","Ronnie","Dino"},
                new string[] { "John","Yomi"},
                new string[] { "Teena","Mathew","Arnold","Goddy"}
            };


            //Display the array elements
            for (int i = 0; i < Members.Length; i++)
            {
                Console.Write("Name List ({0})", i + 1);
                for (int j = 0; j < Members[i].Length; j++)
                {
                    Console.Write(Members[i][j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
