using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{

    class Person
    {
        string name;
        int age;
        string location;
        public void getPersonDetails()
        {
            Console.WriteLine(" Enter the name of the Person");
            name = Console.ReadLine();
            Console.WriteLine(" Enter the age of the Person");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the location of the Person");
            location = Console.ReadLine();
        }
        protected void DisplayPersonDetails()
        {
            Console.WriteLine(" Person Information \n ---------------------");
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Location  :  " + location);
        }
    }
    class Employee:Person
    {
        int employeeId;
        string employeeName;
        double employeeSalary;
        string designation;

        public void getEmployeeDetails()
        {
            Console.WriteLine("Employee Id: ");
            employeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee Name: ");
            employeeName = Console.ReadLine();
            Console.WriteLine("Employee salary: ");
            employeeSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Employee designation: ");
            designation = Console.ReadLine();

            DisplayEmployeeDetails(); //private method can be called within the class
        }

        //by default private access specifier for this method
        void DisplayEmployeeDetails()
        {
            DisplayPersonDetails(); //protected method can be accessed in the sub class
            Console.WriteLine("Employee Details are \n-----------------------\n");
            Console.WriteLine($"Id: {employeeId}\nName: {employeeName}\nSalary: {employeeSalary}\nDesignation: {designation}");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.getEmployeeDetails();
            //employee.DisplayEmployeeDetails(); private method cannot be accessed outside the class

            //employee.DisplayPersonDetails(); //error : child class object cannot access parent class protected members directly
            Console.ReadLine();
        }
    }
}
