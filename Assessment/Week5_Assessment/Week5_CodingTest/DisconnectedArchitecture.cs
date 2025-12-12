using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_CodingTest
{
    internal class DisconnectedArchitecture
    {
        SqlConnection con;
        public DisconnectedArchitecture()
        {
            con = new SqlConnection("uid=sa;pwd=Infinite@2025;database=edutrackdb;server=ICS-LT-HQ4Q9K3");
        }

        //Task 3.1 – Load Students and Courses into a DataSet
        public void LoadStudCourses()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Students", con);
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Courses", con);
            DataSet ds = new DataSet();
            da1.Fill(ds, "Students");
            da2.Fill(ds, "Courses");
            DataTable t1 = ds.Tables["Students"];
            DataTable t2 = ds.Tables["Courses"];
            Console.WriteLine("\nStudents\n");
            foreach (DataRow dr in t1.Rows)
            {
                Console.WriteLine($"{dr["StudentId"]} | {dr["FullName"]} | {dr["Email"]} | {dr["Department"]} | {dr["YearOfStudy"]}");
            }
            Console.WriteLine("\nCourses\n");
            foreach (DataRow dr in t2.Rows)
            {
                Console.WriteLine($"{dr["CourseId"]} | {dr["CourseName"]} | {dr["Credits"]} | {dr["Semester"]}");
            }
        }

        //Task 3.2 – Modify course credits (Disconnected Mode) 
        public void ModifyCourseCredits()
        {
            SqlDataAdapter da = new SqlDataAdapter("select CourseId, CourseName, Credits, Semester from Courses", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Courses");
            DataTable dt = ds.Tables["Courses"];
            Console.Write("Enter CourseId to update credits: ");
            int cid = int.Parse(Console.ReadLine());
            Console.Write("Enter new credits: ");
            int newCredit = int.Parse(Console.ReadLine());
            DataRow row = dt.Select($"CourseId = {cid}").FirstOrDefault();
            if (row != null)
            {
                row["Credits"] = newCredit;
                int updated = da.Update(dt);
                Console.WriteLine($"Rows updated are: {updated}");
            }
            else
            {
                Console.WriteLine("CourseId not present.");
            }
        }

        //Task 3.3 – Insert a new course (Disconnected Mode) 
        public void AddNewCourse()
        {
            SqlDataAdapter da = new SqlDataAdapter("select CourseId, CourseName, Credits, Semester from Courses", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Courses");
            DataTable dt = ds.Tables["Courses"];
            Console.Write("Enter Course Name: ");
            string cname = Console.ReadLine();
            Console.Write("Enter Credits: ");
            int credits = int.Parse(Console.ReadLine());
            Console.Write("Enter Semester: ");
            string sem = Console.ReadLine();
            DataRow dr = dt.NewRow();
            dr["CourseName"] = cname;
            dr["Credits"] = credits;
            dr["Semester"] = sem;
            dt.Rows.Add(dr);
            int inserted = da.Update(dt);
            Console.WriteLine($"Rows inserted are: {inserted}");
        }

        //Task 3.4 – Delete a student (Disconnected Mode)
        public void DeleteStud()
        {
            SqlDataAdapter da = new SqlDataAdapter("select StudentId, FullName, Email, Department, YearOfStudy from Students", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Students");
            DataTable dt = ds.Tables["Students"];
            Console.Write("Enter StudentId: ");
            int studid = int.Parse(Console.ReadLine());
            DataRow dr = dt.Select($"StudentId = {studid}").FirstOrDefault();
            if (dr != null)
            {
                dr.Delete();          
                int affected = da.Update(dt);
                Console.WriteLine($"Rows deleted are: {affected}");
            }
            else
            {
                Console.WriteLine("StudentId not present.");
            }
        }

        //Stored procedure
        public void GetCoursesBySemester()
        {
            Console.Write("Enter semester: ");
            string semester = Console.ReadLine();
            
            SqlDataAdapter da = new SqlDataAdapter("usp_GetCoursesBySemester", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@semester", semester);
            DataSet ds = new DataSet();
            da.Fill(ds, "Courses");
            DataTable dt = ds.Tables["Courses"];
            Console.WriteLine("\nCourseId | CourseName | Credits | Semester\n");
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($"{dr["CourseId"]} | {dr["CourseName"]} | {dr["Credits"]} | {dr["Semester"]}");
            }
            
        }
    }
}
