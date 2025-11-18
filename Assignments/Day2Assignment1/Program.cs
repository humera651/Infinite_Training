using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day2Assignment1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            StudentService studentService = new StudentService();
            WriteLine("All Students: \n-------------------------------------------");
            studentService.ShowAllStudents();

            WriteLine("\nGet Student by ID 2:\n-------------------------------------------");
            var s = await studentService.GetStudentAsync(2);
            WriteLine(s);

            WriteLine("\nDefault details of student without ID:\n-------------------------------------------");
            var defaultStud = await studentService.GetStudentAsync();
            WriteLine(defaultStud);

            ReadLine();
        }
    }
}
