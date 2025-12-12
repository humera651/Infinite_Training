using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_CodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectedArchitecture connectedArchitecture = new ConnectedArchitecture();
            //connectedArchitecture.DisplayAllCourses();
            //connectedArchitecture.AddNewStudent();
            //connectedArchitecture.SearchStudByDept();
            //connectedArchitecture.DisplayEnrolledCourses();
            //connectedArchitecture.UpdateGrade();

            DisconnectedArchitecture disconnectedArchitecture = new DisconnectedArchitecture();
            //disconnectedArchitecture.LoadStudCourses();
            //disconnectedArchitecture.ModifyCourseCredits();
            //disconnectedArchitecture.AddNewCourse();
            //disconnectedArchitecture.DeleteStud();
            disconnectedArchitecture.GetCoursesBySemester();

            Console.Read();
        }
    }
}
