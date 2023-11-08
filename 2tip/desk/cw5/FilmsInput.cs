namespace cw5;

public class FilmsInput
{
    public FilmsInput(List<Film> films)
    {
        Films = films;
    }
    public List<Film> Films { get; set; }
    public void ShowAllFilms(){
        Console.WriteLine(" ================ Wyswietlanie filmow ========");
        foreach(var film in Films){
            ShowFilm(film);
        }
    }
    public void ShowFilm(Film film){
        Console.WriteLine(" Informacje o filmie: ");
        Console.WriteLine($"\tTytul: {film.Title}");
        Console.WriteLine($"\tRezyser: {film.Director}");
        Console.WriteLine($"\tCena: {film.Price} zł");
        Console.WriteLine($"\tOpis: {film.Description}");
    }
}
