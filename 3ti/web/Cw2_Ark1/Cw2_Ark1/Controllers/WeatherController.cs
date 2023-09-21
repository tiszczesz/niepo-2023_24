using Cw2_Ark1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cw2_Ark1.Controllers
{
    public class WeatherController : Controller {
        private WeatherReop _repo;

        public WeatherController(IConfiguration configuration) {
            _repo = new WeatherReop(configuration.GetConnectionString("MySqlConn"));
        }
        public IActionResult Index() {
            var list = _repo.GetWeatherModels();
            return View(list);
        }
    }
}
