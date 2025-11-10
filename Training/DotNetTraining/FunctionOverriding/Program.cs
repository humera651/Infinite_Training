using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment creditCardPayment = new CreditCardPayment();
            creditCardPayment.ProcessPayment(3000);
            creditCardPayment.SamplePayment();
            Console.WriteLine($"{creditCardPayment.Provider}");

            CashOnDelivery cashOnDelivery = new CashOnDelivery();
            cashOnDelivery.ProcessPayment(7000);

            Console.ReadLine();
        }
    }
}
