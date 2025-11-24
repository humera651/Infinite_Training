using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Scenario 1 : Notification Factory
            //Console.WriteLine("Enter notification type (email/sms/push): ");
            //string type = Console.ReadLine();

            //INotification notification = NotificationFactory.GetNotification(type);
            //notification.Send("Hello user! You have a message");

            ////Scenario 2 : Notification Factory
            //Logger.Instance.WriteLog("Application started");
            //Logger.Instance.WriteLog("Notification sent!");

            ////Scenario 3 : Game Character Prototype
            //GameCharacter warriorPrototype = new GameCharacter()
            //{
            //    Health = 100,
            //    Attack = 50,
            //    Defense = 40,
            //    Skills = new List<string> { "Slash", "Block"}
            //};

            //GameCharacter warrior1 = (GameCharacter)warriorPrototype.Clone();
            //GameCharacter warrior2 = (GameCharacter)warriorPrototype.Clone();

            //warrior2.Skills.Add("Rage");

            //Console.WriteLine("Warrior 1:");
            //warrior1.Display();

            //Console.WriteLine("Warrior 2:");
            //warrior2.Display();

            //Scenario 4 : Data Export Template
            DataExporter exporter;

            Console.WriteLine("Exporting CSV");
            exporter = new CsvExporter();
            exporter.Export();

            Console.WriteLine("Exporting JSON");
            exporter = new JsonExporter();
            exporter.Export();

            Console.WriteLine("Exporting XML");
            exporter = new XmlExporter();
            exporter.Export();

            Console.ReadLine();
        }
    }
}
