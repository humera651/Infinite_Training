using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the Payment Option would you choose");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CreditCardPayment creditCardPayment = new CreditCardPayment();
                    creditCardPayment.MakePayment(1000);
                    creditCardPayment.ShowSupportedPaymentMethods();
                    creditCardPayment.Log("payment done!");
                    break;
                case 2:
                    IPaymentGateway uPIPayment = new UPIPayment();
                    uPIPayment.MakePayment(2000);
                    uPIPayment.ShowSupportedPaymentMethods();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            //CreditCardPayment creditCardPayment = new CreditCardPayment();
            //creditCardPayment.MakePayment(1000);
            //creditCardPayment.ShowSupportedPaymentMethods();
            //creditCardPayment.Log("payment done!");

            //UPIPayment uPIPayment = new UPIPayment();
            //uPIPayment.MakePayment(2000);
            //uPIPayment.ShowSupportedPaymentMethods();

            Console.ReadLine();
        }
    }
}
