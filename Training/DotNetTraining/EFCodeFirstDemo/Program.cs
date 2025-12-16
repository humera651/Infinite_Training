using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUDDEMO cRUDDEMO = new CRUDDEMO();
            cRUDDEMO.Insert();

            Console.Read();
        }
    }
}
