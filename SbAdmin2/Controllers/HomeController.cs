using Microsoft.AspNetCore.Mvc;

namespace SbAdmin2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Buttons()
        {
            return View();
        }

        public IActionResult Cards()
        {
            return View();
        }

        public IActionResult Charts()
        {
            return View();
        }

        public IActionResult Tables()
        {
            return View();
        }

        public new IActionResult NotFound()
        {
            return View("404");
        }

        public IActionResult Blank()
        {
            return View("Blank");
        }
    }
}