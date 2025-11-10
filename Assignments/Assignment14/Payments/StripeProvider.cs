using Assignment14.Contracts;
using Assignment14.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14.Payments
{
    public sealed class StripeProvider : PaymentProviderBase
    {
        public override bool AuthorizePayment(IOrder order, bool addressMismatch)
        {
            if (addressMismatch)
                throw new Exception("Address verification failed");
            Console.WriteLine("Stripe: Payment Authorized");
            order.Status = OrderStatus.Authorized;
            return true;
        }

        public override bool CapturePayment(IOrder order)
        {
            if (alreadyCaptured)
                throw new Exception("Duplicate capture attempt");
            Console.WriteLine("Stripe: Payment Captured");
            alreadyCaptured = true;
            order.Status = OrderStatus.Captured;
            return true;
        }
    }
}
