using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Game{
    
    [DisplayName("Tytuł gry")]
    [Required(ErrorMessage = "Podaj tytuł")]
    public string? Title { get; set; }
    
     [DisplayName("Rodzaj gry")]
    [Required(ErrorMessage = "Podaj rodzaj")]
    public string? Genre { get; set; }
    
    
    [Required(ErrorMessage = "Podaj cenę")]
     [DisplayName("Cena gry")]
    public decimal? Price { get; set; }
    
    [DataType(DataType.Date)]
    [DisplayName("Data wydania")]
    [Required(ErrorMessage = "Podaj datę")]
    public DateOnly? DateOf { get; set; }
}