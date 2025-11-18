using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day1Assignment2
{
    public class Assignment3
    {
        private int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        public void Ass3Method()
        {
            Task<int> t = Task.Run(() => Factorial(4));
            WriteLine("Factorial = " + t.Result);
        }
    }
}
