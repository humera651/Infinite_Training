using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public string Gender { get; set; }
    }
    internal class EmployeeList_withIndexDemo
    {
        List<Employee> employeeList = new List<Employee>()
        {
            new Employee(){ EmployeeId = 1,EmployeeName = "Jasmine", Gender = "Male"},
            new Employee(){ EmployeeId = 2,EmployeeName = "Humera", Gender = "Female"},
            new Employee(){ EmployeeId = 3,EmployeeName = "euru", Gender = "Female"}
        };

        public string this[int empid]
        {
            get
            {
                return employeeList.FirstOrDefault(e => e.EmployeeId == empid)?.EmployeeName;
            }
            set
            {
                employeeList.FirstOrDefault(e => e.EmployeeId == empid).EmployeeName = value;
            }
        }
    }
}
