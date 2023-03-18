using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Repos;

namespace WebApplication3.Controllers
{
    public class TraineeController : Controller
    {
        // GET: TraineeController
        public ITrack Track { get; set; }

        public ITrainee Trainee { get; set; }
        public TraineeController(ITrainee trainee, ITrack track)
        {
            Trainee = trainee;
            Track = track;
        }
        // GET: TraineeController1
        public ActionResult Index()
        {
            return View(Trainee.GetAll());
        }

        // GET: TraineeController1/Details/5
        public ActionResult Details(int id)
        {
            return View(Trainee.GetTrainee(id));
        }

        // GET: TraineeController1/Create
        public ActionResult Create()
        {
            ViewBag.Tracks = Track.GetAll();
            return View();
        }

        // POST: TraineeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Trainee trainee)
        {
            try
            {
                Trainee.InsertTrainee(trainee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TraineeController1/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Tracks = Track.GetAll();

            return View(Trainee.GetTrainee(id));
        }

        // POST: TraineeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Trainee trainee)
        {
            try
            {
                Trainee.UpdateTrainee(id, trainee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TraineeController1/Delete/5
        public ActionResult Delete(int id)
        {
            Trainee.DeleteTrainee(id);
            return RedirectToAction("Index");
        }
    }
}
