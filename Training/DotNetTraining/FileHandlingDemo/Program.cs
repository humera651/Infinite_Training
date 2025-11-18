using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\humeras\\Infinite_Training\\Training\\DotNetTraining\\test.txt";

            //Writing to a file
            //using (StreamWriter writer = new StreamWriter(filePath)) 
            //{
            //    writer.WriteLine("Hello, world!");
            //    writer.WriteLine("This is a sample text file");
            //}

            //Reading from a file
            //using (StreamReader reader = new StreamReader(filePath)) 
            //{
            //    string content = reader.ReadToEnd();
            //    Console.WriteLine("File Content");
            //    Console.WriteLine(content);
            //}

            //Appending to a file
            //using (StreamWriter writer = new StreamWriter(filePath, true))
            //{
            //    writer.WriteLine("Appending a new line to the file");
            //}

            //Reading the updated file
            using (StreamReader reader = new StreamReader(filePath))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("Updated File Content");
                Console.WriteLine(content);
            }
        }
    }
}
