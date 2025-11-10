using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14.Contracts
{
    public interface IShipment
    {
        string Carrier {  get; }
        decimal Cost { get; }
        int EstimatedDays { get; }

    }
}
