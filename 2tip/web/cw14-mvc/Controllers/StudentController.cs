using cw14_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw14_mvc.Controllers;

public class StudentController : Controller
{
    public IActionResult Show(){
        var student = new Student{Id=1,FirstName="Adam",LastName="Nowak",Age=22};
        return View(student);
    }
}
