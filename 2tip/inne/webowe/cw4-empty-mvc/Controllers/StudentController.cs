using cw4_empty_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw4_empty_mvc;

public class StudentController :Controller
{
   public IActionResult Index(){
      Student student = new Student{
         Firstname = "Roman",
         Lastname = "Nowak",
         Age = 34,
      };
    return View(student);
   }
   //widok listy studentow w akcji List
}
