using cw1_powtorka.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw1_powtorka.Controllers
{
    public class HolidayController : Controller {
        private PlaceRepo _placeRepo;
        private IConfiguration _configuration;

        public HolidayController(IConfiguration configuration) {
            _configuration = configuration;
            string connString = configuration.GetConnectionString("MySqlConn");
            _placeRepo = new PlaceRepo(connString);
            _placeRepo.GetPlaces();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Happy()
        {
            return View();
        }
        public IActionResult Baza()
        {
            return View();
        }
    }
}
