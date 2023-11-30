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
                RedirectToAction("Index");}
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
