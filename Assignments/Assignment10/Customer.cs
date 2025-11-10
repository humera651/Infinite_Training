using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Customer
    {
        public string name;
        public int loyaltyPoints;

        public Customer(string name,int loyaltyPoints) 
        { 
            this.name = name;
            this.loyaltyPoints = loyaltyPoints;
        }
    }
}
