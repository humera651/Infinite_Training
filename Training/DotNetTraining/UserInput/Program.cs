using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, gender;
            int age;
            int grade,score1,score2,score3;

            Console.WriteLine("Enter firstName,lastName,gender,age,grade,score1,score2,score3 \n");

            firstName = Console.ReadLine();
            lastName = Console.ReadLine();
            gender = Console.ReadLine();
            age = Convert.ToInt16(Console.ReadLine());
            grade = Convert.ToChar(Console.ReadLine());
            score1 = Convert.ToInt16(Console.ReadLine());
            score2 = Convert.ToInt32(Console.ReadLine());
            score3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Student Info \n********************************************\n");
            Console.WriteLine($"Full Name = {firstName} {lastName}");
            Console.WriteLine($"Gender = {gender} \nAge = {age} \n Grade = {grade}");
            Console.WriteLine($"Score1 = {score1} \nScore2 = {score2} \nScore3 = {score3}");

            Console.ReadLine();
        }
    }
}
