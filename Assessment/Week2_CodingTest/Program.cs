using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_CodingTest
{
    public delegate bool EmployeeFilter(Employee e);
    public class Program
    {
        static void ShowFilteredEmployees(List<Employee> list,EmployeeFilter filter)
        {
            foreach (var e in list.Where(x=> filter(x)))
            {
                e.Display();
            }
        }
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(101,"Humera","IT",45000,1),
                new Employee(102,"Mehraj","HR",55000,2),
                new Employee(103,"Pooja","Finance",15000,1),
                new Employee(104,"Keerthi","HR",64000,2),
                new Employee(105,"Saif","IT",85000,4),
                new Employee(106,"Jasmine","Sales",65000,3),
                new Employee(107,"Peter","HR",98000,6),
                new Employee(108,"Aakash","Finance",86000,4),
                new Employee(109,"Charlie","HR",21000,1),
                new Employee(110,"Anita","Finance",75000,3),
            };

            Console.WriteLine("\n===========All Employees=========\n");
            foreach (var e in employees)
                e.Display();

            Console.WriteLine("\nEmployees whose salary > 50000\n");
            ShowFilteredEmployees(employees, e => e.Salary > 50000);

            Console.WriteLine("\nEmployees who work in IT department\n");
            ShowFilteredEmployees(employees, e => e.Department == "IT");

            Console.WriteLine("\nEmployees who have experience > 5 years\n");
            ShowFilteredEmployees(employees, e => e.Experience > 5);

            Console.WriteLine("\nEmployees whose name starts with 'A'\n");
            ShowFilteredEmployees(employees, e => e.Name.StartsWith("A"));

            Console.WriteLine("\nSort by Name (A->Z)\n");
            foreach (var e in employees.OrderBy(e => e.Name))
                e.Display();

            Console.WriteLine("\nSort by Salary (High->Low)\n");
            foreach (var e in employees.OrderByDescending(e => e.Salary))
                e.Display();

            Console.WriteLine("\nSort by Experience (Low->High)\n");
            foreach (var e in employees.OrderBy(e => e.Experience))
                e.Display();

            Console.WriteLine("\nPromotion List (Experience > 5 yrs)\n");
            foreach (var e in employees.Where(e => e.Experience > 5))
                e.Display();

            Console.ReadLine();

        }
    }
}
