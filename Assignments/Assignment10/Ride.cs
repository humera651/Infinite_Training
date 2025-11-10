using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Ride
    {
        public Customer customer;
        public Vehicle vehicle;
        public DateTime rideDate;
        public double distanceKm;

        public Ride(Customer customer, Vehicle vehicle, DateTime rideDate, double distanceKm)
        {
            this.customer = customer;
            this.vehicle = vehicle;
            this.rideDate = rideDate;
            this.distanceKm = distanceKm;
        }

        public void ComputeBill(out double subTotal,out double gst,out double total,params string[] addOns)
        {
            subTotal = vehicle.baseFare + (vehicle.perKmRate * distanceKm);
            subTotal += Pricing.AddOnsCost(addOns);

            double weekendPercent;
            bool isWeekend = Pricing.TryGetWeekendSurcharge(rideDate, out weekendPercent);
            if (isWeekend && weekendPercent > 0)
            {
                subTotal += subTotal * weekendPercent / 100;
            }
            gst = Pricing.CalculateGst(subTotal);
            total = subTotal + gst;
        }

        public double GetGst(double amount)
        {
            return Pricing.CalculateGst(amount);
        }

        public double GetAddOns(params string[] addOns)
        {
            return Pricing.AddOnsCost(addOns);
        }

        public bool GetWeekendSurcharge(out double percent)
        {
            return Pricing.TryGetWeekendSurcharge(rideDate, out percent);
        }
    }
}
