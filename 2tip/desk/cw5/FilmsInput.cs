namespace cw5;

public class FilmsInput
{
    public FilmsInput(List<Film> films)
    {
        Films = films;
    }
    public List<Film> Films { get; set; }
    public void ShowAllFilms()
    {
        Console.WriteLine(" ================ Wyswietlanie filmow ========");
        foreach (var film in Films)
        {
            ShowFilm(film);
        }
    }
    public void ShowFilm(Film film)
    {
        Console.WriteLine(" Informacje o filmie: ");
        Console.WriteLine($"\tTytul: {film.Title}");
        Console.WriteLine($"\tRezyser: {film.Director}");
        Console.WriteLine($"\tCena: {film.Price} zł");
        Console.WriteLine($"\tOpis: {film.Description}");
    }
    public Film GetFilm()
    {
        Console.WriteLine(" ==== Podaj parametry filmu:   ");
        Console.Write("Podaj tytyl: ");
        string? title = Console.ReadLine()?.Trim();
        Console.Write("Podaj rezysera: ");
        string? director = Console.ReadLine()?.Trim();
        Console.Write("Podaj cene: ");
        string? price = Console.ReadLine()?.Trim();
        Console.Write("Podaj opis: ");
        string? description = Console.ReadLine()?.Trim();
        //bez walidacji
        return new Film{
            Id = -1,
            Title = title,
            Director = director,
            Price = Convert.ToDecimal(price),
            Description = description
        };
    }
}
