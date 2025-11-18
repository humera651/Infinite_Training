using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day2Assignment1
{
    public class StudentService
    {
        private Dictionary<int,Student> students = new Dictionary<int, Student>()
        {
            {1,new Student {Name = "Humera",Class="10th",TotalMarks=450,Gender='F'} },
            {2,new Student {Name = "Charlie",Class="9th",TotalMarks=250,Gender='M'} },
            {3,new Student {Name = "Sayali",Class="7th",TotalMarks=550,Gender='F'} },
        };

        public void ShowAllStudents()
        {
            foreach (var s in students)
                WriteLine($"ID: {s.Key} => {s.Value.ToString()}");  
        }

        public async Task<Student> GetStudentAsync(int id = 0)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (!students.ContainsKey(id))
                    {
                        return new Student
                        {
                            Name = "Default",
                            Class = "N/A",
                            TotalMarks = 0,
                            Gender = '-'
                        };
                    }
                    var st = students[id];
                    if (st.TotalMarks < 300)
                        throw new Exception("less than 500");
                    return st;
                });
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("less than 500"))
                {
                    await Task.Delay(10);
                    WriteLine("Exception occurred: " + ex.Message);
                }
                return null;
            }
        }
    }
}
