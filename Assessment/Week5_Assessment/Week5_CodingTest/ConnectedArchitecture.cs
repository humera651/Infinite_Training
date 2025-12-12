using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_CodingTest
{
    internal class ConnectedArchitecture
    {
        SqlConnection con;
        public ConnectedArchitecture()
        {
            con = new SqlConnection("uid=sa;pwd=Infinite@2025;database=edutrackdb;server=ICS-LT-HQ4Q9K3");
        }

        //Task 2.1 – Display all courses
        public void DisplayAllCourses()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select CourseId, CourseName, Credits, Semester from Courses", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]}    {dr[1]}    {dr[2]}    {dr[3]}");
            }
            con.Close();
        }

        //Task 2.2 – Add a new student
        public void AddNewStudent()
        {
            con.Open();
            Console.WriteLine("Enter full name:");
            string fullName = Console.ReadLine();

            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter department:");
            string department = Console.ReadLine();

            Console.WriteLine("Enter year of study:");
            int year = int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("insert into Students(FullName,Email,Department,YearOfStudy) VALUES(@n,@e,@d,@y)", con);
            cmd.Parameters.AddWithValue("@n", fullName);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@d", department);
            cmd.Parameters.AddWithValue("@y", year);

            int rowaffected = cmd.ExecuteNonQuery();

            Console.WriteLine("Total Records Inserted is " + rowaffected);
            con.Close();
        }

        //Task 2.3 – Search students by department 
        public void SearchStudByDept()
        {
            con.Open();

            Console.WriteLine("Enter department:");
            string department = Console.ReadLine();

            SqlCommand cmd = new SqlCommand("select StudentId, FullName, Email from Students where Department = @dept", con);
            cmd.Parameters.AddWithValue("@dept", department);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]}    {dr[1]}    {dr[2]}");
            }
            con.Close();
        }

        //Task 2.4 – Display enrolled courses for a student
        public void DisplayEnrolledCourses()
        {
            con.Open();

            Console.WriteLine("Enter student id:");
            int studentId = int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand(@"select c.CourseName, c.Credits, e.EnrollDate, e.Grade
                                from Enrollments e inner join Courses c ON e.CourseId = c.CourseId
                                where e.StudentId = @sid", con);
            cmd.Parameters.AddWithValue("@sid", studentId);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]} | {dr[1]} | {dr[2]} | {dr[3]}");
            }
            con.Close();
        }

        //Task 2.5 – Update grade (Connected Mode)
        public void UpdateGrade()
        {
            con.Open();

            Console.WriteLine("Enter grade:");
            string grade = Console.ReadLine();

            Console.WriteLine("Enter enrollment id:");
            int enrollmentId = int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("UPDATE Enrollments SET Grade = @g WHERE EnrollmentId = @id", con);
            cmd.Parameters.AddWithValue("@g", grade);
            cmd.Parameters.AddWithValue("@id", enrollmentId);
            
            int rowaffected = cmd.ExecuteNonQuery();

            Console.WriteLine("Total Records Updated is " + rowaffected);
        }
    }
}
