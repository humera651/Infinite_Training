using Assignment14.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14.Processing
{
    public abstract class OrderProcessorBase
    {
        public void ProcessOrder(IOrder order)
        {
            Console.WriteLine($"Processing order #{order.Id} for {order.BuyerEmail}");

            Validate(order);
            Price(order);
            AuthorizePayment(order);
            ReserveStock(order);
            QuoteShipment(order);
            CapturePayment(order);
            CreateShipment(order);
            SendNotifications(order);
            Persist(order);
        }

        protected virtual void Validate(IOrder order) 
        {
            for (int i = 0; i < order.Items.Length; i++) 
            {
                if (order.Items[i].Quantity <= 0 || order.Items[i].UnitPrice <= 0)
                    throw new Exception("Invalid line item detected");
            }
        }

        protected abstract void Price(IOrder order);
        protected abstract void AuthorizePayment(IOrder order);
        protected virtual void ReserveStock(IOrder order)
        {
            Console.WriteLine("Stock reserved successfully");
        }
        protected abstract void QuoteShipment(IOrder order);
        protected abstract void CapturePayment(IOrder order);
        protected abstract void CreateShipment(IOrder order);
        protected abstract void SendNotifications(IOrder order);
        protected abstract void Persist(IOrder order);
    }

    public class SimpleOrderProcessor : OrderProcessorBase
    {
        public IPricingStrategy pricing;
        private IPaymentProvider payment;
        private IShipmentQuoter quoter1;
        private IShipmentQuoter quoter2;
        private INotifier email;
        private INotifier sms;

        public SimpleOrderProcessor(IPricingStrategy pricing, IPaymentProvider payment, IShipmentQuoter quoter1, IShipmentQuoter quoter2, INotifier email, INotifier sms)
        {
            this.pricing = pricing;
            this.payment = payment;
            this.quoter1 = quoter1;
            this.quoter2 = quoter2;
            this.email = email;
            this.sms = sms;
        }

        protected override void Price(IOrder order)
        {
            order.TotalAmount = pricing.CalculateTotal(order.Items);
            Console.WriteLine($"Order total calculated: Rs{order.TotalAmount}");
        }

        protected override void AuthorizePayment(IOrder order)
        {
            payment.AuthorizePayment(order,false);
        }

        protected override void QuoteShipment(IOrder order)
        {
            if (quoter1 == null && quoter2 == null) 
            {
                Console.WriteLine("No shipment quoters are available");
                return;
            }
            IShipment s1 = quoter1?.QuoteShipment(order);
            IShipment s2 = quoter2?.QuoteShipment(order);

            IShipment chosen;
            if (s1 == null) chosen = s2;
            else if (s2 == null) chosen = s1;
            else chosen = (s1.Cost <= s2.Cost) ? s1 : s2;
            
            Console.WriteLine($"Shipment selected: {chosen.Carrier} (Cost Rs{chosen.Cost} , {chosen.EstimatedDays} days)");
        }

        protected override void CapturePayment(IOrder order)
        {
            payment.CapturePayment(order);
        }

        protected override void CreateShipment(IOrder order)
        {
            Console.WriteLine("Shipment created successfully");
            order.Status = Domain.OrderStatus.Shipped;
        }

        protected override void SendNotifications(IOrder order)
        {
            email.Send(order.BuyerEmail, "Your order has been shipped");
            sms.Send(order.BuyerEmail, "Shipment on its way");
        }

        protected override void Persist(IOrder order)
        {
            Console.WriteLine("Order saved to database");
        }
    }
}
