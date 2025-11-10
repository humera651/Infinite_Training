using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Welcome to RideEasy-----------");

            Console.WriteLine("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Ride Date: .e.g.YYYY-MM-DD");
            string rideDate = Console.ReadLine();

            Console.WriteLine("Enter Loyalty Points: ");
            int loyaltyPoints = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Vehicle Type: ");
            string type = Console.ReadLine();

            Console.WriteLine("Enter Base Fare: ");
            double baseFare = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Fare Per Km: ");
            double perKm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Distance (km): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nAvailable Add-ons: ");
            Console.WriteLine("1. child-seat");
            Console.WriteLine("2. fast-tag");
            Console.WriteLine("3. priority-pickup");
            Console.WriteLine("4. extra-luggage");

            string[] addOns = new string[4];
            int count = 0;

            while(count < 4)
            {
                Console.Write("Enter add-on name (or 'done' to finish): ");
                string add = Console.ReadLine().ToLower();

                if (add == "done" || add == "")
                    break;
                addOns[count] = add;
                count++;
                if (count >= addOns.Length)
                    break;
            }

            Array.Resize(ref addOns, count);

            Customer customer = new Customer(name, loyaltyPoints);
            Vehicle vehicle = new Vehicle(type, baseFare, perKm);
            Ride ride = new Ride(customer, vehicle,DateTime.Now,distance);

            ride.ComputeBill(out double subTotal, out double gst, out double total, addOns);

            Console.Write("\nENter Coupon Discount Amount (or 0 if none): ");
            double coupon = Convert.ToDouble(Console.ReadLine());
            if(coupon > 0)
            {
                Pricing.ApplyCoupon_ByRef(ref total, coupon);
            }

            Pricing.RedeemLoyalty(ref customer.loyaltyPoints, ref total);

            Console.WriteLine("\n-----------Ride Details------------");
            Console.WriteLine($"Customer: {customer.name}");
            Console.WriteLine($"Ride Date: {rideDate}");
            Console.WriteLine($"Vehicle: {vehicle.type}");
            Console.WriteLine($"Distance: {distance} Km");
            Console.WriteLine($"SubTotal: Rs{subTotal}");
            Console.WriteLine($"GST (18%): Rs{gst}");
            Console.WriteLine($"Total Amount: {total}");
            Console.WriteLine($"Remaining Loyalty Points: {customer.loyaltyPoints}");

            Console.ReadLine();
        }
    }
}
