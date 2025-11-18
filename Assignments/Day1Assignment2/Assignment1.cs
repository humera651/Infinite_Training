using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day1Assignment2
{
    public class Assignment1
    {
        public void Ass1Method()
        {
            Task t1 = Task.Run(() =>
            {
                for (int i = 1; i <= 5; i++)
                    WriteLine(i);
            });

            Task t2 = Task.Run(() =>
            {
                for (int i = 6; i <= 10; i++)
                    WriteLine(i);
            });

            Task t3 = Task.Run(() =>
            {
                    WriteLine("All numbers printed!");
            });

            Task.WaitAll(t1,t2,t3);
            WriteLine("Done");
        }
    }
}
