using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //single inheritance
    class Person //base class for employee class
    {
        string name;
        int age;
        string location;

        public Person(string name,int age,string location)
        {
            this.name = name;
            this.age = age;
            this.location = location;
            Console.WriteLine("Person or Base Class Constructor");
        }

        public void getPersonDetails()
        {
            Console.WriteLine("Enter the name of the person");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age of the person");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the location of the person");
            location = Console.ReadLine();
        }

        public void DisplayPersonDetails()
        {
            Console.WriteLine("Person Information \n --------------------");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Location: " + location);
        }
    }
    class Employee:Person //inherited the person class
    {
        int employeeId;
        double employeeSalary;
        string designation;

        //sending the details (name,age,location) from subclass to parent class
        public Employee(string name, int age, string location,int empId,double empSal,string desig):base(name,age,location) 
        {
            this.employeeId = empId;
            this.employeeSalary = empSal;
            this.designation = desig;
            Console.WriteLine("Employee or Child Class Constructor");
        }

        public void getEmployeeDetails()
        {
            Console.WriteLine("Employee Id: ");
            employeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee salary: ");
            employeeSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Employee designation: ");
            designation = Console.ReadLine();

        }

        //by default private access specifier for this method
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details are \n-----------------------\n");
            Console.WriteLine($"Id: {employeeId}\nSalary: {employeeSalary}\nDesignation: {designation}");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Employee employee = new Employee("Humera",24,"bangalore",101,45000,"Associate S/W Developer");
            //employee.getPersonDetails();
            //employee.getEmployeeDetails();

            //employee.DisplayPersonDetails();
            employee.DisplayEmployeeDetails();
            Console.ReadLine();
        }
    }
}