using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo
{
    class Student
    {
        private int age;
        private string name;
        private double salary = 45000;
        private string password = "admin123";
        public int Age
        {
            get { return age; }
            set {
                if (value < 0 || value > 120)      //validation 
                    throw new Exception("Age should be between 0 to 120");
                age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Read Only Property
        public double Salary
        {
            get { return salary; }
        }
        //Write Only Property
        public string Password
        {
            set { password = value; }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //student.Age = 30;
            Console.WriteLine("Enter your age: ");
            student.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name: ");
            student.Name = Console.ReadLine();     
            //student.Name = "Peter";              
            //student.Salary = 90000; //error: coz it is read only property

            Console.WriteLine("Student Information");
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Age: " + student.Age);
            Console.WriteLine("Stipend: " + student.Salary);

            //Console.WriteLine("Password: " + student.Password); //error: coz it is write only property

            Console.ReadLine();
        }
    }
}
