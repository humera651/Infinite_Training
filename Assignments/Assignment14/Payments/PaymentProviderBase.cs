using Assignment14.Contracts;
using Assignment14.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14.Payments
{
    public abstract class PaymentProviderBase : IPaymentProvider
    {
        public bool alreadyCaptured = false;
        public virtual bool AuthorizePayment(IOrder order,bool addressMismatch)
        {
            if (addressMismatch)
            {
                throw new Exception("Authorization failed due to address mismatch");
            }
            order.Status = OrderStatus.Authorized;
            return true;
        }

        public virtual bool CapturePayment(IOrder order)
        {
            if (alreadyCaptured)
            {
                throw new Exception("Payment already captured!");
            }
            alreadyCaptured = true;
            order.Status = OrderStatus.Captured;
            return true;
        }
    }
}
