using ark1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ark1.Controllers
{
    public class LibraryController : Controller {
        private RepoReaders _repo;

        public LibraryController(IConfiguration configure) {
            string connString = configure.GetConnectionString("MySqlConn");
            _repo = new RepoReaders(connString);
        }
        public IActionResult Index() {
            _repo.GetAllReaders();
            return View();
        }
    }
}
