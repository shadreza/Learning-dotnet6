using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
            // return "This is a Index page!";
        }

        public string Hello()
        {
            return "Who is there?";
        }
    }
}
