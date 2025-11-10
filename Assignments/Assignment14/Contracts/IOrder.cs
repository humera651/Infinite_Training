using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment14.Domain;

namespace Assignment14.Contracts
{
    public interface IOrder
    {
        int Id { get; }
        string BuyerEmail { get; }
        string ShipToCity { get; }
        double TotalWeightKg { get; }
        ILineItem[] Items { get; }
        decimal TotalAmount { get; set; }
        OrderStatus Status { get; set; }

    }
}
