using cw6_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw6_mvc.Controllers;

public class FilmsController : Controller
{
    private readonly FilmsRepo _reop;
    public FilmsController(IConfiguration configuration){
        _reop = new FilmsRepo(configuration);
    }
    public IActionResult List(){
        return View();
    }
}
