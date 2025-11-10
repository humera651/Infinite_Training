using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectMethods
{
    internal class Employee
    {
        private int empId;
        private string empName;
        private string designation;

        public void AcceptEmployeeDetails(int id, string name, string desig="Jr. Associate") //default desig given
        {
            empId = id;
            empName = name;
            designation = desig;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID: " + empId);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Employee Designation: " + designation);
        }
    }
}
