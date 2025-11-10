using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14.Contracts
{
    public interface IPaymentProvider
    {
        bool AuthorizePayment(IOrder order,bool addressMismatch =  false);
        bool CapturePayment(IOrder order);
    }
}
