using Microsoft.AspNetCore.Mvc;

namespace MVC_Courses.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
