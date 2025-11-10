using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Student
    {
        public string name;
        public int[] subjectMarks = new int[3];

        public void CalculateResult(out int total,out double average,out string grade)
        {
            total = 0;
            for (int i = 0; i < subjectMarks.Length; i++)
            {
                total += subjectMarks[i];
            }

            average = total/3;

            if (average >= 90)
                grade = "A";
            else if(average >=75)
                grade = "B";
            else if(average >=65)
                grade = "C";
            else if(average >=55)
                grade = "D";
            else if(average >=45)
                grade = "E";
            else
                grade = "F";
        }

        public void DisplayResult()
        {
            CalculateResult(out int total,out double average,out string grade);
            Console.WriteLine("\nStudent Report\n------------------------------\n");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Total Marks : {total}");
            Console.WriteLine($"Average : {average}");
            Console.WriteLine($"Grade : {grade}");
        }

    }
}
