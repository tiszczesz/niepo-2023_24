using Microsoft.AspNetCore.Mvc;

namespace Animals.Controllers
{
    public class AnimalsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
