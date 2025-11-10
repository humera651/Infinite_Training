using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ Student Marks Evaluation System ============\n");

            Console.Write("Enter number of students: ");
            int numStudent = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numStudent; i++)
            {
                Student student = new Student();

                Console.WriteLine($"Enter details for Student #{i + 1}");
                Console.Write("Enter Student Name: ");
                student.name = Console.ReadLine();

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter marks for Subject {j + 1}: ");
                    student.subjectMarks[j] = Convert.ToInt32(Console.ReadLine());
                }

                student.DisplayResult();
            }
            Console.ReadLine();
        }
    }
}
