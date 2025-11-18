using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ClassLibraryDemo
    {
        public (int, string) tupledemo()
        {
            // Features : using tuple u can return multiple values
            // now its standards
            int id = 100;
            string name = "Deepa";

            return (id, name);
        }

        public void outdemo()
        {// converting from string to integer?
         // int.Parse // converts string int
         // double.Parse // converts string double
         //float.Parse() string to float
         //  int a = int.Parse(Console.ReadLine());

            // Features : the better way/ safest way  to typecast
            // try parse will avoid runtime errors 

            var res = int.TryParse(Console.ReadLine(), out int x);
            if (res == true)
                Console.WriteLine("u have entered " + x);
            else
                Console.WriteLine("Convertion failed");
        }

        public void Greet()
        {
            Console.WriteLine("Hello world");
        }
    }
}
