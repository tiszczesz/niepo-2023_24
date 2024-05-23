using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw6_mvc.Models;

public class Film
{
    public int Id { get; set;}
    
    [DisplayName("Tytuł")]
    [Required(ErrorMessage = "Podaj tytuł")]
    public string? Title { get; set; }  
    
     [DisplayName("Reżyser")]
     [Required(ErrorMessage = "Podaj reżysera")]
    public string? Director { get; set; }
    
     [DisplayName("Rok produkcji")]
     [Required(ErrorMessage = "Podaj rok produkcji")]
    public int? Year { get; set; }
    
     [DisplayName("Cena")]
     [Required(ErrorMessage = "Podaj cenę")]
    public decimal? Price { get; set; }
}
