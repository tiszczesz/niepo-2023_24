using Microsoft.AspNetCore.Mvc;

namespace cw3_fromEmpty.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
