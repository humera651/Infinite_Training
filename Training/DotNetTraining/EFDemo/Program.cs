using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUDDEMO ob = new CRUDDEMO();
            //ob.showallemployees();
            //ob.SearchRecord();
            //ob.AddRecord();
            //ob.DeleteRecord();
            ob.UpdateRecord();

            Console.Read();
        }
    }
}
