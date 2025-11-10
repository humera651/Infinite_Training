using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department(); //default constructor
            department.DisplayDepartmentInfo();

            Department department1 = new Department(201,"humera","bangalore"); //parameterized constructor
            department1.DisplayDepartmentInfo();

            Department department2 = new Department(301, "jasmine", "chennai"); //parameterized constructor
            department2.DisplayDepartmentInfo();

            Department department3 = new Department(department2); //copy constructor
            department3.DisplayDepartmentInfo();

            Console.ReadLine();
        }
    }
}
