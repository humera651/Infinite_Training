using Assignment14.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14.Infrastructure
{
    internal interface IOrderRepository
    {
        void Save(IOrder order);
    }
}
