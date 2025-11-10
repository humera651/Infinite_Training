using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    public abstract class ShippingCalculator
    {
        public abstract decimal Calculate(decimal weight, string zone);

        public virtual string Label()
        {
            return "Generic Shipping Service";
        }
    }

    public class StandardShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            decimal baseRate = 50;
            decimal ratePerKg = 10;

            if (zone == "A") ratePerKg = 8;
            else if (zone == "B") ratePerKg = 12;
            else if (zone == "C") ratePerKg = 15;

            return baseRate + (weight * ratePerKg);
        }

        public override string Label()
        {
            return "Standard Shipping (Delivery in 3-5 days)";
        }
    }

    public class ExpressShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            decimal baseRate = 100;
            decimal ratePerKg = 20;

            if (zone == "A") ratePerKg = 18;
            else if (zone == "B") ratePerKg = 22;
            else if (zone == "C") ratePerKg = 25;
        
            return baseRate + (weight * ratePerKg);
        }

        public override string Label()
        {
            return "Express Shipping (Delivery in 1-2 days)";
        }
    }

    public class InternationalShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            decimal baseRate = 500;
            decimal ratePerKg = 50;

            if (zone == "Asia") ratePerKg = 40;
            else if (zone == "Europe") ratePerKg = 60;
            else if (zone == "US") ratePerKg = 70;

            return baseRate + (weight * ratePerKg);
        }

        public override string Label()
        {
            return "International Shipping (Delivery in 7-10 days)";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ShippingCalculator standard = new StandardShipping();
            ShippingCalculator express = new ExpressShipping();
            ShippingCalculator international = new InternationalShipping();

            Console.WriteLine($"{standard.Label()} => Cost: Rs {standard.Calculate(5,"B")}");
            Console.WriteLine($"{express.Label()} => Cost: Rs {express.Calculate(3, "C")}");
            Console.WriteLine($"{international.Label()} => Cost: Rs {international.Calculate(10, "US")}");

            Console.ReadLine();
        }
    }
}
