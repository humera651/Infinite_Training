using Assignment14.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14.Shipping
{
    public sealed class DelhiveryQuoter : ShipmentQuoterBase
    {
        public override IShipment QuoteShipment(IOrder order)
        {
            int totalItems = 0;
            for (int i = 0; i < order.Items.Length; i++)
            {
                totalItems += order.Items[i].Quantity;
            }

            decimal cost = 50 + (28 * (decimal)order.TotalWeightKg);
            if (order.ShipToCity == "Mumbai" || order.ShipToCity == "Delhi")
            {
                cost = cost - (cost * 0.08m);
            }
            return new Shipment("Delhivery", cost, 3);
        }

        private class Shipment : IShipment
        {
            public string Carrier { get; }
            public decimal Cost { get; }
            public int EstimatedDays { get; }

            public Shipment(string carrier, decimal cost, int estimatedDays)
            {
                Carrier = carrier;
                Cost = cost;
                EstimatedDays = estimatedDays;
            }
        }
    }
}
