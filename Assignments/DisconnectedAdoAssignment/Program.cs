using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedAdoAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisconnectedCls disconnectedCls = new DisconnectedCls();
            //Task-1
            //disconnectedCls.DisplayEmployeeDepartment();

            //Task-2
            //disconnectedCls.EmployeeDataView();

            //Task-3
            //disconnectedCls.TotalTables();

            //Task-4
            //disconnectedCls.CopyReaderToDataTable();

            //Task-5
            //disconnectedCls.MergeCustomerOrders();

            //Task-6
            disconnectedCls.ReadXmlData();

            Console.ReadLine();
        }
    }
}
