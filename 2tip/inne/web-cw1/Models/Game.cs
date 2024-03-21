using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace web_cw1.Models;

public class Game
{
    [Display(Name = "Tytuł")]
    [Required(ErrorMessage = "Podaj tytuł")]
    [MinLength(3,ErrorMessage = "Tytuł musi mieć minimum 3 znaki")]
    public string? Title { get; set; }
    
    [Display(Name = "Cena")]
    [Required(ErrorMessage = "Podaj cenę")]
    public decimal? Price { get; set; }
    
    [DisplayName("Wybierz rodzaj")]
    public string Genre { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Wybierz datę produkcji")]
    public DateOnly EditDate { get; set; }

}
