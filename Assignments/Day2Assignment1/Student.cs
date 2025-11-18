using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment1
{
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int TotalMarks { get; set; }
        public char Gender { get; set; }

        public override string ToString()
            => $"Name: {Name}, Class: {Class}, Total Marks: {TotalMarks}";
    }
}
