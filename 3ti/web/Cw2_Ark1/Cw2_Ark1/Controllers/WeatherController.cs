using Microsoft.AspNetCore.Mvc;

namespace Cw2_Ark1.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
