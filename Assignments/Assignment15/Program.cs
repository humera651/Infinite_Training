using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15
{
    class InterestCalculator
    {
        public double CalculateInterest(double principal, double rate)
        {
            double time = 1;
            double si = (principal * rate * time) / 100;
            return si;
        }

        public double CalculateInterest(double principal, double rate, double time)
        {
            double si = (principal * rate * time) / 100;
            return si;
        }

        public double CalculateInterest(double principal, double rate, double time, int n)
        {
            double amount = principal * Math.Pow((1 + (rate / (100 * n))), n * time);
            double ci = amount - principal;
            return ci;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            InterestCalculator calc = new InterestCalculator();

            double si1 = calc.CalculateInterest(10000, 5);
            Console.WriteLine("Simple Interest (1 year): " + si1);

            double si2 = calc.CalculateInterest(10000, 5, 2);
            Console.WriteLine("Simple Interest (2 years): " + si2);

            double ci = calc.CalculateInterest(10000, 5, 2, 2);
            Console.WriteLine("Compound Interest (2 years, compounded half-yearly):" + ci);

            Console.ReadLine();
        }
    }
}
