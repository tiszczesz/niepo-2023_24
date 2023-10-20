using Microsoft.AspNetCore.Mvc;
using MVC_Courses.Models;

namespace MVC_Courses.Controllers
{
    public class CoursesController : Controller {
        private CoursesRepo repo;

        public CoursesController(IConfiguration configuration) {
            repo = new CoursesRepo(configuration.GetConnectionString("MySqlConn"));

        }
        public IActionResult Index(int? id) {
           //var divisions = repo.GetDivisions();
           ViewBag.courses = repo.GetDivisions();
           List<Student> students = repo.GetStudents(id);
            return View(students);
        }

      
    }
}
