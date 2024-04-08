using Microsoft.AspNetCore.Mvc;

namespace cw14_mvc.Controllers;

public class HomeController : Controller
{
    public string Index(){
        return "Hello from Index and Home";
    }
    public string Welcome(){
        return "damina bbbbbb";
    }
    public IActionResult  Index2(){
        return View();
    }
}
