using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SolidPrinciplesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("--------SRP Demo---------");
            Invoice invoice = new Invoice();
            invoice.GenerateInvoice();

            InvoiceRepository repo = new InvoiceRepository();
            repo.SaveToDatabase(invoice);

            InvoiceEmailService emailService = new InvoiceEmailService();
            emailService.SendEmail(invoice);

            ReadLine();
        }
    }
}
