using Assignment14.Contracts;
using Assignment14.Domain;
using Assignment14.Notifications;
using Assignment14.Payments;
using Assignment14.Pricing;
using Assignment14.Processing;
using Assignment14.Shipping;
using System;

namespace Assignment14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILineItem[] items = new ILineItem[]
            {
                new LineItem("Phone",1,12000m),
                new LineItem("Charger",2,500m)
            };

            IOrder order = new Order(1, "customer@gmail.com", "Mumbai", 2.5, items);

            IPricingStrategy pricing = new TieredDiscountStrategy();
            IPaymentProvider payment = new RazorpayProvider();
            IShipmentQuoter quoter1 = new BluedartQuoter();
            IShipmentQuoter quoter2 = new DelhiveryQuoter();
            INotifier email = new EmailNotifier();
            INotifier sms = new SmsNotifier();

            SimpleOrderProcessor processor = new SimpleOrderProcessor(pricing, payment,quoter1,quoter2, email, sms);
            processor.ProcessOrder(order);

            Console.WriteLine("\n===== ORDER SUMMARY =====");
            Console.WriteLine($"Order ID: {order.Id}");
            Console.WriteLine($"Customer: {order.BuyerEmail}");
            Console.WriteLine($"City: {order.ShipToCity}");
            Console.WriteLine($"Weight: {order.TotalWeightKg} kg");
            Console.WriteLine($"Total: Rs {order.TotalAmount}"); 
            Console.WriteLine($"Status: {order.Status}");
            Console.WriteLine("==========================");

            Console.ReadLine();
            
        }
    }
}
