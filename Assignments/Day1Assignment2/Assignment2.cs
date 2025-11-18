using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day1Assignment2
{
    public class Assignment2
    {
        Random random = new Random();

        public void Ass2Method()
        {
            Task<int> t1 = Task.Run(() => random.Next(1, 50));
            Task<int> t2 = Task.Run(() => random.Next(1, 50));
            Task<int> t3 = Task.Run(() => random.Next(1, 50));

            Task.WhenAll(t1, t2, t3).ContinueWith(task =>
            {
                int sum = t1.Result + t2.Result + t3.Result;
                WriteLine("Sum = " + sum);
            }).Wait();

        }
    }
}
