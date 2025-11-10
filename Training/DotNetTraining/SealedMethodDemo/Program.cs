using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedMethodDemo
{
    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle : run for pre-run checks");
        }
    }
    public class Car : Vehicle
    {
        public override void Start()
        {
            base.Start();
            Console.WriteLine("Car : starts with a key");
        }
    }
    public class ElectricCar : Car 
    {
        public sealed override void Start()
        {
            base.Start();
            Console.WriteLine("ElectricCar : starts with a button");
        }
    }

    //public class HybridCar : ElectricCar
    //{
    //    //the following override would cause a compile-time error
    //    public override void Start()
    //    {
    //        base.Start();
    //        Console.WriteLine("ElectricCar : starts with a button");
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            ElectricCar electricCar = new ElectricCar();
            electricCar.Start();

            Console.ReadLine();
        }
    }
}
