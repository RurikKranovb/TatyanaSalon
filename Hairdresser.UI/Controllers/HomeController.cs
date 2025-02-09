using Microsoft.AspNetCore.Mvc;

namespace Hairdresser.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult About() => View();
        public IActionResult Appointment() => View();
        public IActionResult Contact() => View();
        public IActionResult Opening() => View();
        public IActionResult Price() => View();
        public IActionResult Service() => View();
        //public IActionResult Team() => View();
        public IActionResult Testimonial() => View();
    }
}
