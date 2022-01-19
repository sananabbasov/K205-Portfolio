using Microsoft.AspNetCore.Mvc;

namespace K205_Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
