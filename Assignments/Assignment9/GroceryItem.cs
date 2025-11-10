using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class GroceryItem
    {
        public string name;
        public int quantity;
        public int pricePerUnit;

        public double CalculateItemTotal()
        {
            return quantity * pricePerUnit;
        }
    }
}
