using cw14_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw14_mvc;

public class StudentsController : Controller
{
    public IActionResult Show()
    {
        var student = new Student { Id = 1, FirstName = "Adam", LastName = "Nowak", Age = 22 };
        return View(student);
    }
    public IActionResult List()
    {
        var students = StudentRepo.GetStudents();
        return View(students);
    }
}
