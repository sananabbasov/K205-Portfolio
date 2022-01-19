using Microsoft.AspNetCore.Mvc;

namespace K205_Portfolio.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
