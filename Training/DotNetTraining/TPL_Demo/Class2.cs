using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Demo
{
    internal class Class2
    {
        public delegate string mydel();

        public object mymethod()
        {
            return "hello";
        }

        // optional parameter : is achived  by assiging the default value for parameter
        // named parameter : is achived by using paramter name and then pass the value

        // drawback is : it may not run if use function overloading
        public void NamedoptionalDemo(int x = 10, int y = 30)
        {
            int result = x + y;
            Console.WriteLine($"The sum is {result}");
        }
        public void NamedoptionalDemo()
        {
            Console.WriteLine("Hello world");
        }

        public void CoVariance_Contravariance()
        {
            // feature : to make delegate more flexible use covariance and contravariance

            // .net 1.0

            //Co varience You can use a derived type instead of a base type.
            // contravarince : You can use a base type instead of a derived type.
            string[] st = { "hello", "welcome" };
            object[] o = st;

            IEnumerable<string> names = new List<string>();
            IEnumerable<object> objs = names; // Covariance - valid

        }

        public void dynamicdemo()
        {
            // var : varient

            var a = 100;// datatype is checked at compile time

            //var a1 = "hi";
            //var a2 = a * a1;
            //var b = "hi";
            //var c = 10.5;

            dynamic m = 100;//  datatype is checked runtime time
            dynamic n = "hi";
            dynamic o = m * n;

            //dynamic a = 10; //integer
            //Console.WriteLine(a);

            //a = "hi";// string
            //Console.WriteLine(a);

            //a = 10.5;// double
            //Console.WriteLine(a);


            //1 var cannot be declared globally
            //2. multiple var variables not allowed in a single line
            //3. you have to assign the values
            //4.null values cannot assigned
            // 5. cannot be used as function parameter

        }

        //public delegate object mydel();// base type

        public delegate void mydel2(string st);//derived 


        public string cov() { return "hi"; }// derived type

        public void con(object st)// base type
        { Console.WriteLine("hello"); }

        //Co varience You can use a derived type instead of a base type.
        public void hello()
        {

            mydel d = cov;
            Console.WriteLine(d());

            mydel2 d2 = con;
            d2("hi");
        }
    }
}
