using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();
            Professor professor1 = new Professor() { Name = "Peter", Course = "Maths" };

            professor.Name = "Geetha";
            professor.Course = "Dot Net";

            professor.ShowName();
            professor.ShowCourse();
            professor.ConductResearch();

            Console.ReadLine();
        }
    }
}
