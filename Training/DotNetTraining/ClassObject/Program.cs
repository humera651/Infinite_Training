using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1, num2;
            //Calculator calculator = new Calculator(); //instance or obj declaration and initialization

            //Console.WriteLine("Enter num1");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter num2");
            //num2 = Convert.ToInt32(Console.ReadLine()); 

            //calculator.Add(num1, num2);
            //calculator.Subtract(num1, num2);

            //Employee employee = new Employee();
            //employee.AcceptEmployeeDetails(101, "Humera", "Software Engineer");
            //employee.DisplayEmployeeDetails();

            //Employee employee1 = new Employee();
            //employee1.AcceptEmployeeDetails(102, "Rozy", "QA");
            //employee1.DisplayEmployeeDetails();

            //Employee employee = new Employee();
            //int empId;
            //string empName;
            //string designation;

            //Console.WriteLine("Enter EmployeeId,Name,Designation");
            //empId = Convert.ToInt32(Console.ReadLine());
            //empName = Console.ReadLine();
            //designation = Console.ReadLine();

            //employee.AcceptEmployeeDetails(empId, empName, designation); //parameters with correct sequence
            //employee.DisplayEmployeeDetails();

            //employee.AcceptEmployeeDetails(id: empId, desig: designation, name: empName); //named parameters when sequence is changed
            //employee.DisplayEmployeeDetails();

            //employee.AcceptEmployeeDetails(designation, empName, empId); //compile time error due to wrong datatype in parameters

            //employee.AcceptEmployeeDetails(empId,designation, empName); //no errors but expected output is changed due to sequence change
            //employee.DisplayEmployeeDetails();

            //Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.Add(b:20,a:10)); //named parameters

            //int additionResult =calculator.Add(20,10);
            //Console.WriteLine($"Addition Result is {additionResult} \n Average is {additionResult/2}");

            //calculator.Calculate(20, 10, out int addResult, out int difference, out int productResult, out int divisionResult);
            //Console.WriteLine($"Addition is {addResult}\n Difference is {difference}\n Product result is {productResult}\n Division result is {divisionResult}");

            Employee employee = new Employee();
            employee.AcceptEmployeeDetails(101, "humera"); //designation will be default since not passed here
            employee.DisplayEmployeeDetails();

            employee.AcceptEmployeeDetails(102, "lily", "tester");
            employee.DisplayEmployeeDetails();

            Console.ReadLine();

        }
    }
}
