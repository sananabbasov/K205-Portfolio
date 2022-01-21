using K205_Portfolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace K205_Portfolio.Controllers
{
    public class HomeController : Controller
    {
       
        List<Product> products= new() {
            new Product { 
                Id = 1, 
                Name = "IPhone 11", 
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." ,
                PhotoURL = "https://cdn.pixabay.com/photo/2017/03/16/05/23/singapore-2148190_960_720.jpg"
            },
            new Product { 
                Id=2,
                Name= "Xiomi",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                PhotoURL = "https://cdn.pixabay.com/photo/2021/12/02/02/59/mountains-6839521_960_720.jpg"
            },
            new Product
            {
                Id = 2,
                Name = "Xiomi",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                PhotoURL = "https://cdn.pixabay.com/photo/2021/12/02/02/59/mountains-6839521_960_720.jpg"
            }
        };

        public IActionResult Index()
        {

            // ViewData, ViewBag ve ViewTemp


            //var gun = "axsam";

            //var salamlama = "Sabahiniz xeyir";

            //if (gun != "seher")
            //    salamlama = "Axsaminiz xeyir";



            //ViewBag.Salamlama = salamlama;

            ViewData["products"] = products;



            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
