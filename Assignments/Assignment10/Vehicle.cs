using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Vehicle
    {
        public string type;
        public double baseFare,perKmRate;

        public Vehicle(string type, double baseFare, double perKmRate)
        {
            this.type = type;
            this.baseFare = baseFare;
            this.perKmRate = perKmRate;
        }
    }
}
