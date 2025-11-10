using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        public void Log(string message, int level)
        {
            Console.WriteLine($"Level {level} - Message: {message}");
        }

        public void Log(string message, DateTime time)
        {
            Console.WriteLine($"[{time}] Message: {message}");
        }

        public void Log(string message, int level, DateTime time)
        {
            Console.WriteLine($"[{time}] Level {level} - Message: {message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            logger.Log("System started successfully");
            logger.Log("Low disk space warning", 2);
            logger.Log("Backup completed",DateTime.Now);
            logger.Log("Critical error detected",5,DateTime.Now);

            Console.ReadLine();
        }
    }
}
