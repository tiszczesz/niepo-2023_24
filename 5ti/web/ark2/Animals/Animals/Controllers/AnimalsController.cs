using Animals.Models;
using Microsoft.AspNetCore.Mvc;

namespace Animals.Controllers
{
    public class AnimalsController : Controller {
        private string connString;
        private AnimalsRepo repo;

        public AnimalsController(IConfiguration configure) {
            connString = configure.GetConnectionString("myConn");
            repo = new AnimalsRepo(connString);
        }
        public IActionResult Index()
        {
           var animals = repo.GetAnimals();
           ViewBag.animals = animals;
            return View();
        }
    }
}
