using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageForm.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image

        public ActionResult ImageData()
        {

            return View();
        }
        public ActionResult ViewDetails(int id,string name,string imgnum)
        {
            ViewBag.id = id;
            ViewBag.name = name;
            
            ViewBag.imgnum = "/Images/" + imgnum?.ToString() ;
            return View();
        }


        public ActionResult Index()
        {
            return View();
        }
    }
}