using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUDCls cRUDCls = new CRUDCls();
            //cRUDCls.DisplayEmployeeDept();
            //cRUDCls.DisplayIdName();
            //cRUDCls.DisplayEmpBetweenDates();
            //cRUDCls.DisplayEmpIdNameSalary();
            //cRUDCls.InsertEmployee();
            cRUDCls.DeleteEmployee();

            Console.ReadLine();
        }
    }
}
