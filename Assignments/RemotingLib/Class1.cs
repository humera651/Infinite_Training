using Day3Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RemotingLib
{
    [Serializable]
    public class ServiceClass : MarshalByRefObject , IMyinter
    {
        private Dictionary<int, Student> students = new Dictionary<int, Student>()
        {
            {1,new Student {Name = "Humera",Class="10th",TotalMarks=450,Gender='F'} },
            {2,new Student {Name = "Charlie",Class="9th",TotalMarks=760,Gender='M'} },
            {3,new Student {Name = "Sayali",Class="7th",TotalMarks=550,Gender='F'} },
        };

        public string ShowAllStudents()
        {
            string result = "";
            foreach (var s in students)
                result += $"ID: {s.Key} => {s.Value.ToString()}\n";

            return result;
        }

        public Student GetStudent(int id = 0)
        {
            try
            {
                if (id == 0)
                {
                    return new Student
                    {
                        Name = "Default",
                        Class = "N/A",
                        TotalMarks = 0,
                        Gender = '-'
                    };
                }

                if (!students.ContainsKey(id))
                {
                    throw new Exception("Student not found");
                }

                Student stu = students[id];

                if (stu.TotalMarks < 300)
                {
                    throw new Exception("Mark less than 300");
                }
                    
                
                return stu;

            }
            catch (Exception ex)
            {
                WriteLine($"Error: {ex.Message}");
                return new Student();
            }

        }

    }
}
