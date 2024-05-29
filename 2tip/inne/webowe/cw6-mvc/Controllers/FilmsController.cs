using cw6_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw6_mvc.Controllers;

public class FilmsController : Controller
{
    private readonly FilmsRepo _repo;
    public FilmsController(IConfiguration configuration){
        _repo = new FilmsRepo(configuration);
    }
    public IActionResult List(){
        var films = _repo.GetFilms();
        return View(films);
    }
    [HttpGet]
    public IActionResult InsertFilm(){
        return View();
    }
    [HttpPost]
    public IActionResult InsertFilm(Film? film){
        if(film!=null){ 
            if(ModelState.IsValid){
                _repo.InserFilm(film); 
                return RedirectToAction("List");
            }           
        }
        return View(film);
    }
}
