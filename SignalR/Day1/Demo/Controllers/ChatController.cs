using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
