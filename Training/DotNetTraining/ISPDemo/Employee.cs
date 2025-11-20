using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo
{
    internal class Employee : IWorker,IEatable
    {
        public void Work()
        {
            Console.WriteLine("Employee working..");
        }
        public void Eat()
        {
            Console.WriteLine("Employee eating..");
        }
    }
}
