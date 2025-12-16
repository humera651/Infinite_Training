using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUDDemo cRUDDemo = new CRUDDemo();
            //cRUDDemo.AddEmployee();
            //cRUDDemo.DisplayEmployee();
            //cRUDDemo.UpdateEmployee();
            cRUDDemo.DeleteEmployee();

            Console.Read();
        }
    }
}
