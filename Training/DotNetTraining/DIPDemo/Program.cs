using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------DIP Demo-------");
            IDatabase db = new SqlDatabase();
            OrderProcessor op = new OrderProcessor(db);
            op.Process();

            Console.ReadLine();
        }
    }
}
