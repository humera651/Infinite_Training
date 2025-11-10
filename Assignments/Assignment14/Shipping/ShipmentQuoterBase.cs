using Assignment14.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14.Shipping
{
    public abstract class ShipmentQuoterBase : IShipmentQuoter
    {
        public abstract IShipment QuoteShipment(IOrder order);
    }
}
