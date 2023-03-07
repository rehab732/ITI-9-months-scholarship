using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeCRUD.Models;
namespace EmployeeCRUD.Controllers
{
    public class StudentController : Controller
    {
        ITIEntities context=new ITIEntities();
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.department = context.Departments.ToList();


            return View(context.Students.ToList());
        }
        [HttpPost]
        public ActionResult Index(int Dept_Id)
        {
            var stu=context.Students.Where(s=>s.Dept_Id==Dept_Id);
            ViewBag.department = context.Departments.ToList();

            return View(stu);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            Student student = context.Students.Find(id);

            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            ViewBag.department = context.Departments.ToList();



            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                Student student = new Student();
                student.St_Id =int.Parse( collection["St_Id"]);

                student.St_Fname = collection["St_Fname"];
                student.St_Lname = collection["St_Lname"];
                student.St_Address = collection["St_Address"];
                student.St_Age = int.Parse(collection["St_Age"]);
                student.Dept_Id = int.Parse(collection["Dept_Id"]);
                Student studentt = context.Students.Add(student);

                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            Student student = context.Students.Find(id);
            ViewBag.department = context.Departments.ToList();
            return View(student);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Student student = context.Students.Find(id);
                student.St_Fname= collection["St_Fname"];
                student.St_Lname = collection["St_Lname"];
                student.St_Address = collection["St_Address"];
                student.St_Age = int.Parse(collection["St_Age"]);
                student.Dept_Id = int.Parse(collection["Dept_Id"]);

                context.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {

            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
