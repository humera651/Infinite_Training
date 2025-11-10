using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    class StudentMarks
    {
        private int[] marks = new int[5];
        public int this[int index]
        {
            get
            {
                if (index < 0  || index >= marks.Length)
                {
                    Console.WriteLine("Invalid index! Returning -1");
                    return -1;
                }
                return marks[index];
            }
            set
            {
                if (index < 0 || index >= marks.Length)
                {
                    Console.WriteLine("Invalid Index! Cannot set value");
                }
                else
                {
                    marks[index] = value;
                }
            }
        }
        public void DisplayMarks()
        {
            Console.WriteLine("Marks of Students");
            for(int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Student {i+1}: {marks[i]}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //StudentMarks studentMarks = new StudentMarks();

            ////Setting marks using indexer
            //studentMarks[0] = 87;
            //studentMarks[1] = 77;
            //studentMarks[2] = 73;
            //studentMarks[3] = 56;
            //studentMarks[4] = 76;

            ////Attempting to set an invalid index
            //studentMarks[5] = 88; //Should display an error message

            ////Getting marks uisng indexer
            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Marks of Student {i+1} : {studentMarks[i]}");
            //}

            ////Attempting to get an invalid index
            //Console.WriteLine($"Marks of Student 6: {studentMarks[5]}"); //Should display an error message

            ////Display all marks
            //studentMarks.DisplayMarks();

            EmployeeList_withIndexDemo employee = new EmployeeList_withIndexDemo();
            Console.WriteLine($"employee[2]: {employee[2]}"); //getting the value

            Console.WriteLine($"employee[3]: {employee[3]}");
            employee[3] = "Euru";                             //setting the value
            Console.WriteLine($"employee[3]: {employee[3]}");

            Console.ReadLine();

        }
    }
}
