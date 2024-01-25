using Microsoft.AspNetCore.Mvc;
using WebAppMysqlEF.Models;

namespace WebAppMysqlEF.Controllers
{
    public class MyCarsController : Controller {
        private AppDbContext _db;

        public MyCarsController(AppDbContext dbContext) {
            _db = dbContext;
        }
        public IActionResult List() {
            return View(_db.Cars.ToList());
        }

        public IActionResult Delete(int? id) {
            if (id != null) {
                Car? carToRemove = _db.Cars.FirstOrDefault(c => c.Id == id);
                if (carToRemove != null) {
                    _db.Cars.Remove(carToRemove);
                    _db.SaveChanges();
                }
            }
            return RedirectToAction("List");
        }
    }
}
