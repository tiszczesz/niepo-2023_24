using Microsoft.AspNetCore.Mvc;

namespace solution.Controllers
{
    public class AnimalController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
