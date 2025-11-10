using Assignment14.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14.Domain
{
    public class LineItem : ILineItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public LineItem(string name, int quantity, decimal unitPrice)
        {
            Name = name;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
