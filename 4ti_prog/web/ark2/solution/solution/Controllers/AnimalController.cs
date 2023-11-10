using Microsoft.AspNetCore.Mvc;
using solution.Models;

namespace solution.Controllers
{
    public class AnimalController : Controller {
        private AnimalsDb db;

        public AnimalController(IConfiguration config) {
            db = new AnimalsDb(config.GetConnectionString("mysqlConn"));
        }
        public IActionResult Index() {
            List<Animal> animals = db.GetAllAnimals();
            return View(animals);
        }
    }
}
