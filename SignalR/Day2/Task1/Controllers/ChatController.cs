using Microsoft.AspNetCore.Mvc;

namespace Task1.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {

			return View();
        }
    }
}
