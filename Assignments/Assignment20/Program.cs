using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }

        public Order(int orderID, string customerName, decimal totalAmount)
        {
            OrderID = orderID;
            CustomerName = customerName;
            TotalAmount = totalAmount;
        }

        public override string ToString()
        {
            return $"Order ID: {OrderID}, Customer: {CustomerName}, Amount: Rs{TotalAmount}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList orderList = new ArrayList();

            orderList.Add(new Order(101, "Ayaan", 450.22m));
            orderList.Add(new Order(102, "Zara", 300.00m));
            orderList.Add(new Order(103, "Kabir", 700.00m));

            
            while (true)
            {
                Console.WriteLine("\n======= FOODIFY ORDER MANAGEMENT =======");
                Console.WriteLine("1. Add New Order");
                Console.WriteLine("2. Display All Orders");
                Console.WriteLine("3. Search Order By ID");
                Console.WriteLine("4. Remove Order By ID");
                Console.WriteLine("5. Show Total Number of Orders");
                Console.WriteLine("6. Sort Orders By Amount");
                Console.WriteLine("7. Reverse Order List");
                Console.WriteLine("8. Exit");

                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Order ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Customer Name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Total Amount: ");
                        decimal amount = Convert.ToDecimal(Console.ReadLine());

                        orderList.Add(new Order(id, name, amount));
                        Console.WriteLine("Order added successfully");

                        break;
                    case 2:
                        if (orderList.Count == 0)
                        {
                            Console.WriteLine("No orders available!");
                            return;
                        }

                        Console.WriteLine("\n--- Current Orders ---");
                        foreach (Order order in orderList)
                        {
                            Console.WriteLine(order);
                        }

                        break;
                    case 3:
                        Console.Write("Enter Order ID to search: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());

                        Order foundOrder = null;
                        foreach (Order order in orderList)
                        {
                            if (order.OrderID == searchId)
                            {
                                foundOrder = order;
                                break;
                            }
                        }

                        if (foundOrder != null)
                        {
                            Console.WriteLine($"Found Order: Id: {foundOrder.OrderID}, Customer Name: {foundOrder.CustomerName}, Total Amount: {foundOrder.TotalAmount}");
                        }
                        else
                        {
                            Console.WriteLine("❌ Order not found!");
                        }
                        break;
                    case 4:
                        Console.Write("Enter Order ID to remove: ");
                        int removeid = Convert.ToInt32(Console.ReadLine());

                        Order orderToRemove = null;

                        foreach (Order order in orderList)
                        {
                            if (order.OrderID == removeid)
                            {
                                orderToRemove = order;
                                break;
                            }
                        }

                        if (orderToRemove != null)
                        {
                            orderList.Remove(orderToRemove);
                            Console.WriteLine("Order removed successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Order not found!");
                        }
                        break;
                    case 5:
                        Console.WriteLine($"\nTotal Orders: {orderList.Count}");
                        break;
                    case 6:
                        orderList.Sort(new OrderAmountComparer());
                        Console.WriteLine("\nOrders sorted by total amount!");
                        foreach (Order order in orderList)
                        {
                            Console.WriteLine($"Order ID: {order.OrderID},Customer Name: {order.CustomerName},Total Amount: {order.TotalAmount}");
                        }
                        break;
                    case 7:
                        orderList.Reverse();
                        Console.WriteLine("\nOrders in reverse order");
                        foreach (Order order in orderList)
                        {
                            Console.WriteLine($"Order ID: {order.OrderID},Customer Name: {order.CustomerName},Total Amount: {order.TotalAmount}");
                        }
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
                Console.ReadLine();
            }
        }
        class OrderAmountComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                Order o1 = (Order)x;
                Order o2 = (Order)y;
                return o1.TotalAmount.CompareTo(o2.TotalAmount);
            }
        }
    }
}
