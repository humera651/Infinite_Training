using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Assignment1
{
    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string message) 
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }

    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending SMS: " + message);
        }
    }

    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Push Notification: " + message);
        }
    }
    public static class NotificationFactory
    {
        public static INotification GetNotification(string type)
        {
            type = type.ToLower();
            if (type == "email")
                return new EmailNotification();
            else if (type == "sms")
                return new SmsNotification();
            else if (type == "push")
                return new PushNotification();
            else
                throw new Exception("Invalid notification type");
        }
    }
}
