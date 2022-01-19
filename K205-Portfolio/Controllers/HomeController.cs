using Microsoft.AspNetCore.Mvc;

namespace K205_Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            // ViewData, ViewBag ve ViewTemp


            var gun = "axsam";

            var salamlama = "Sabahiniz xeyir";

            if (gun != "seher")
                salamlama = "Axsaminiz xeyir";



            ViewBag.Salamlama = salamlama;

            
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
