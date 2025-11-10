using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example of Dynamic Array Size

            //int rowSize,colSize;
            //Console.WriteLine("Enter number of rows (or) students");

            //rowSize =Convert.ToInt32(Console.ReadLine());
            //colSize = 5; //fixed number of subjects

            //int[,] StudentMarks = new int[rowSize,colSize];

            //for (int i = 0; i < rowSize; i++)
            //{
            //    Console.WriteLine($"Enter the marks for Student{i + 1}");
                
            //    for (int j = 0; j < colSize; j++)
            //    {
            //        Console.WriteLine($"Enter the marks for Subject{j+1}");
            //        StudentMarks[i,j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Displaying the marks of students");
            //for (int i = 0;i < rowSize; i++)
            //{
            //    Console.WriteLine($"\nStudent {i+1} marks are \n");
            //    for(int j = 0;j < colSize; j++)
            //    {
            //        Console.Write(StudentMarks[i,j] + "\t");
            //    }
            //    Console.WriteLine("\n");
            //}

            ////Calculating total marks per student
            //for (int i = 0; i < StudentMarks.GetLength(0); i++)
            //{
            //    int total = 0;
            //    for (int j = 0; j < StudentMarks.GetLength(1); j++)
            //    {
            //        total += StudentMarks[i, j];
            //    }
            //    Console.WriteLine($"Total marks for Student {i + 1} is {total}");
            //}


            //Reverse single dimensional array
            int[] myArray = new int[5] { 10, 20, 30, 40, 50 };
            foreach (int item in myArray)
            {
                Console.Write(item + "\t");
            }

            Console.WriteLine("\n");
            Console.WriteLine("After reversing the array is ");
            Array.Reverse(myArray);
            foreach(int item in myArray)
            {
                Console.Write(item + "\t");
            }

            Console.ReadLine();
        }
    }
}
