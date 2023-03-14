using Microsoft.AspNetCore.Mvc;

namespace Day7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
