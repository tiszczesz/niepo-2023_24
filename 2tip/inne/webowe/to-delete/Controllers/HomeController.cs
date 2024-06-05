using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using to_delete.Models;

namespace to_delete.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private BooksRepo _repo;

    public HomeController(ILogger<HomeController> logger,IConfiguration configuration)
    {
        _logger = logger;
        _repo = new BooksRepo(configuration);
    }

    public IActionResult Index()
    {
        var books = _repo.GetAll();
        return View(books);
    }

    public IActionResult Delete(int? id){
        if(id != null){
            _repo.Delete(id);
        }
        return RedirectToAction("Index");
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
