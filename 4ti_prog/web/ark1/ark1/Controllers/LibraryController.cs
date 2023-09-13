using ark1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ark1.Controllers; 

public class LibraryController : Controller {
    private readonly RepoReaders _repo;

    public LibraryController(IConfiguration configure) {
        var connString = configure.GetConnectionString("MySqlConn");
        _repo = new RepoReaders(connString);
    }

    [HttpGet]
    public IActionResult Index() {
        var list = _repo.GetAllReaders();
        ViewBag.list = list;
        return View();
    }

    [HttpPost]
    public IActionResult Index(Reader reader) {
        if (ModelState.IsValid) {
            _repo.AddReader(reader);
        }

        var list = _repo.GetAllReaders();
        ViewBag.list = list;
        return View();
    }
}