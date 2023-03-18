using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication3.Models;
using WebApplication3.Repos;

namespace WebApplication3.Controllers
{
    public class TrackController : Controller
    {
        public ITrack track { get; set; }
        public TrackController(ITrack track1)
        {
         track= track1;
        }
        // GET: TrackController
        public ActionResult Index()
        {
            return View(track.GetAll().ToList());
        }

        // GET: TrackController/Details/5
        public ActionResult Details(int id)
        {
            return View(track.GetTrack(id));
        }

        // GET: TrackController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrackController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Track track1)
        {
            try
            {
                track.InsertTrack(track1);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TrackController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(track.GetTrack(id));
        }

        // POST: TrackController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,Track track1)
        {
            try
            {
                track.UpdateTrack(id, track1);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TrackController/Delete/5
        public ActionResult Delete(int id)
        {
            track.DeleteTrack(id);
            return RedirectToAction("Index");
        }

        // POST: TrackController/Delete/5
    
    }
}
