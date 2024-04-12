using Microsoft.AspNetCore.Mvc;

namespace cw14_mvc;

public class PhysicsController :Controller
{
    public IActionResult Newton(){
        return View();
    }
    public IActionResult About(){
        string text = "ala ma kota";
        return View("Newton", text);
    }
}
