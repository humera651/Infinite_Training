using MVC_DatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DatabaseFirst.Controllers
{
    public class StudentController : Controller
    {
        infinitedbEntities5 db = new infinitedbEntities5();
        // GET: Student
        public ActionResult Index()
        {
            //1. The below action method uses scaffolded view
            List<Student> studlist = db.Students.ToList();
            return View(studlist);
        }

        //2. the below action method does not use scaffolded view
        public ActionResult GetStudentDetails()
        {
            List<Student> studlist = db.Students.ToList();
            return View(studlist);
        }

        //3. Adding or inserting a new student
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student) // passing data from view to controller thru model object 
        {
            db.Students.Add(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //4 deleting student
        public ActionResult Delete(int Id)
        {
            Student s = db.Students.Find(Id);
            return View(s);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteStudent(int Id)
        {
            Student stud = db.Students.Find(Id);
            db.Students.Remove(stud);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //5. student details
        public ActionResult Details(int Id)
        {
            Student student = db.Students.Find(Id);
            return View(student);
        }

        //6. edit
        public ActionResult Edit(int Id)
        {
            Student student = db.Students.Find(Id);
            return View(student);
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult Update(Student student)
        {
            Student c = db.Students.Find(student.StudentRollNumber);
            c.StudentName = student.StudentName;
            c.DOB = student.DOB;
            c.Class = student.Class;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //7. sorting category by name
        public ActionResult GetCategoryByName()
        {
            List<String> sortedcatlist = (from c in db.Students
                                          orderby c.StudentName
                                          select c.StudentName).ToList();

            return View(sortedcatlist);
        }

    }
}