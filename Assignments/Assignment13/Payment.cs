using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    interface IPaymentGateway
    {
        void MakePayment(double amount);
        void ShowSupportedPaymentMethods();
    }

    class RefundablePaymentProcessor
    {
        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($"Refunding payment of {amount}");
        }
    }
    class CreditCardPayment : RefundablePaymentProcessor,IPaymentGateway,ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now} : {message}");
        }

        public void MakePayment(double amount)
        {
            Console.WriteLine("Payment of Rs." + amount + " done using credit card");
            LogPayment();
        }

        public void ShowSupportedPaymentMethods() 
        {
            Console.WriteLine("Supported method: credit card");
        }

        private void LogPayment()
        {
            Console.WriteLine("Payment logged successfully\n");
        }
    }

    class UPIPayment : IPaymentGateway
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine("Payment of Rs." + amount + " done using UPI");
            LogPayment();
        }

        public void ShowSupportedPaymentMethods()
        {
            Console.WriteLine("Supported method: UPI");
        }
        private void LogPayment()
        {
            Console.WriteLine("Payment logged successfully\n");
        }
    }
    
}
