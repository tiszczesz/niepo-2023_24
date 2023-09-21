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
            string code = reader.FirstName.Substring(0,2).ToLower()+
                          reader.Year.ToString().Substring(reader.Year.ToString().Length-2)
                          + reader.LastName.Substring(0, 2).ToLower();
            reader.Code = code;
            _repo.AddReader(reader);
        }

        var list = _repo.GetAllReaders();
        ViewBag.list = list;
        return View(reader);
    }
}