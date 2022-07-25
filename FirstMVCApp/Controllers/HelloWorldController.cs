using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel() { Name = "Sif", Age= 3};
            return View(doggo);
            // return "This is a Index page!";
        }

        public string Hello()
        {
            return "Who is there?";
        }
    }
}
