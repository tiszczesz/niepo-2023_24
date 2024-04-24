namespace cw6_mvc.Models;

public class Film
{
    public int Id { get; set;}
    public string? Title { get; set; }  
    public string? Director { get; set; }
    public int? Year { get; set; }
    public decimal? Price { get; set; }
}
