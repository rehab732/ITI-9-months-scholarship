using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication3.Models;
using WebApplication3.Repos;

namespace WebApplication3.Controllers
{
    public class CourseController : Controller
    {
        public ICoursecs coursecs1  { get; set; }
        public ITrainee trainee1 { get; set; }
        public CourseController(ICoursecs coursecs,ITrainee trainee)
        {
            coursecs1 = coursecs;
            trainee1 = trainee;
        }
        // GET: CourseController
        public ActionResult Index()
        {
            return View(coursecs1.GetAll().ToList());
        }

        // GET: CourseController/Details/5
        public ActionResult Details(int id)
        {
           
            return View(coursecs1.GetCourse(id));
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            ViewBag.Course = trainee1.GetAll();
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course course)
        {
            try
            {
                coursecs1.InsertCourse(course);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Course = trainee1.GetAll();

            return View(coursecs1.GetCourse(id));
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Course course)
        {
            try
            {
                coursecs1.UpdateCourse(id, course);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Delete/5
        public ActionResult Delete(int id)
        {
            coursecs1.DeleteCourse(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: CourseController/Delete/5

    }
}
