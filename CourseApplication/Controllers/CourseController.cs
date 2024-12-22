using Microsoft.AspNetCore.Mvc;

namespace CourseApplication.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();   // burası get için çalışan methoddur
        }
        [HttpPost]

        public IActionResult Apply(Candidate model)
        {
            return View();   // burası post için çalışan methoddur
        }

    }
}
