using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    //Exercise 1: Create First Test Case
    //Exercise 2: Test with Multiple Assertions
    public class Calculator
    {
        public int Square(int a) => a * a;

        public int Multiply(int a, int b) => a * b;
    }
    //Exercise 3: Test Case Attribute
    public class StringHelper
    {
        public string ToUpper(string input) => input.ToUpper();
    }

    //Exercise 4: Test Exceptions
    public class StudentService
    {
        public void ValidateAge(int age)
        {
            if (age < 0) throw new ArgumentException("Invalid age");
        }
    }

    //Exercise 6: Collection Assertions
    public class CollectionAssertions()
    {
        public List<int> GetEvenNumbers() => new List<int> { 2, 4, 6, 8 };
    }

    //Exercise 8: Testing Asynchronous Method
    public class AsyncClass()
    {
        public async Task<int> GetMarksAsync()
        {
            await Task.Delay(100);
            return 90;
        }
    }

}
