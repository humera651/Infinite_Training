using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class InfiniteEmployee: IComparable<InfiniteEmployee>
    {
        public int Empid {  get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public int Age { get; set; }
        public string Location { get; set; }

        public int CompareTo(InfiniteEmployee other)
        {
            return this.Empid.CompareTo(other.Empid);
        }
    }
    internal class IComparableInterfaceDemo
    {
        static void Main(string[] args)
        {
            List<InfiniteEmployee> infiniteEmployees = new List<InfiniteEmployee>();
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1, Name = "Humera", Salary = 90000, Age = 24,Location = "Bangalore" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 2, Name = "Jasmine", Salary = 80000, Age = 20, Location = "Chennai" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807007, Name = "Hyma", Salary = 21000, Age = 22, Location = "Hyderabad" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 851, Name = "Monika", Salary = 18000, Age = 21, Location = "Vizag" });

            Console.WriteLine("Employee Details are ");
            foreach (var emp in infiniteEmployees)
            {
                Console.WriteLine($"EmpId: {emp.Empid}, EmpName: {emp.Name}, Salary: {emp.Salary}, Age: {emp.Age}, Location: {emp.Location}");
            }

            infiniteEmployees.Sort();
            Console.WriteLine("\nEmployee Details after sorting by Salary");
            foreach (var emp in infiniteEmployees)
            {
                Console.WriteLine($"EmpId: {emp.Empid}, EmpName: {emp.Name}, Salary: {emp.Salary}, Age: {emp.Age}, Location: {emp.Location}");
            }

            Console.ReadLine();
        }
    }
}
