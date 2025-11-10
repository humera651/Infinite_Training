using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14.Contracts
{
    public interface IPricingStrategy
    {
        decimal CalculateTotal(ILineItem[] items);
    }
}
