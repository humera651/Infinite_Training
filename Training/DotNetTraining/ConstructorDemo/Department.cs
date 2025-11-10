using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    internal class Department
    {
        int departmentId;
        string departmentName, deptLocation;

        //static constructor
        static Department()
        {
            Console.WriteLine("Static Constructor called");
        }

        //default constructor or parameterless constructor
        public Department() { 
            departmentId = 1;
            departmentName = "Unknown";
            deptLocation = "Unknown";
            Console.WriteLine("Default or parameterless constructor called");
        }

        //parameterized constructor
        public Department(int id, string name, string location)
        {
            this.departmentId = id;
            this.departmentName = name;
            this.deptLocation = location;
            Console.WriteLine("Parameterized constructor called");
        }

        //Copy constructor
        public Department(Department dept)
        {
            Console.WriteLine("Copy constructor called");
            this.departmentId = 104;
            this.departmentName = "HR";
            this.deptLocation = dept.deptLocation;
        }

        public void getDepartmentInfo()
        {
            Console.WriteLine("Enter department id");
            departmentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter department name");
            departmentName = Console.ReadLine();
            Console.WriteLine("Enter department location");
            deptLocation= Console.ReadLine();
        }

        public void DisplayDepartmentInfo()
        {
            Console.WriteLine("Department details");
            Console.WriteLine("Id : " + departmentId);
            Console.WriteLine("Name : " + departmentName);
            Console.WriteLine("Location : " + deptLocation);
        }
    }
}
