using Microsoft.AspNetCore.Mvc;
using mvc_ef_mssql.Models;
using System.Diagnostics;

namespace mvc_ef_mssql.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private SchoolDbContext _context;

        public HomeController(ILogger<HomeController> logger, SchoolDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }

        public IActionResult Details(int id) {
            var student = _context.Students.Find(id);
            if (student == null) {
                return RedirectToAction("Index");
            }
            return View(student);
        }

        public IActionResult Delete(int id) {
            var student = _context.Students.Find(id);
            if (student != null) {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult InsertStudent() {
            return View();
        }

        [HttpPost]
        public IActionResult InsertStudent(Student student)
        {
            if (ModelState.IsValid) {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        [HttpGet]
        public IActionResult Update(int id) {
            Student? student = _context.Students.Find(id);
            if (student == null) {
                return RedirectToAction("Index");
            }

            return View(student);
        }

        [HttpPost]
        public IActionResult Update(Student student)
        {
            
            if (ModelState.IsValid)
            {
                _context.Students.Update(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
