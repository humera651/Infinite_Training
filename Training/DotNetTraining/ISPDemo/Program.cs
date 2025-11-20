using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------ISP Demo--------");
            IWorker employee = new Employee();
            IEatable eatable = new Employee();
            employee.Work();
            eatable.Eat();

            IWorker manager = new Manager();
            IEatable eatable1 = new Manager();
            IManager manager1 = new Manager();
            manager.Work();
            eatable1.Eat();
            manager1.ManageTeam();

            Console.ReadLine();
        }
    }
}
