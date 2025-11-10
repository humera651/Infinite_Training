using Assignment14.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14.Notifications
{
    internal class SmsNotifier : INotifier
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Email sent to {to}: {message}");
        }
    }
}