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
        var films = _reop.GetFilms();
        return View(films);
    }
    [HttpGet]
    public IActionResult InserFilm(){
        return View();
    }
    [HttpPost]
    public IActionResult InserFilm(Film? film){
        if(film!=null){ 
            if(ModelState.IsValid){
                _reop.InserFilm(); 
                return RedirectToAction("List");
            }           
        }
        return View(film);
    }
}
