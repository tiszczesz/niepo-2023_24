using Microsoft.AspNetCore.Mvc;

namespace cw4_empty_mvc.Controllers;

public class HomeController : Controller
{
    public string Index(){
        return "Hello from Index in Home";
    }
    public IActionResult Index2(){
        return View();
    }

}
