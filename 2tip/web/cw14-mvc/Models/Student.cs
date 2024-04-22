using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw14_mvc.Models;

public class Student
{
    public int Id { get; set;}
    
    [DisplayName("Podaj imię")]
    [Required(ErrorMessage = "Musisz podać imię")]
    public string? FirstName { get; set; }

    [DisplayName("Podaj nazwisko")]
    [Required(ErrorMessage = "Musisz podać nazwisko")]
    public string? LastName { get; set; }
    
    [Required(ErrorMessage = "Podaj poprawny wiek")]
    [DisplayName("Podaj wiek")]
    public int? Age { get; set; }
}
