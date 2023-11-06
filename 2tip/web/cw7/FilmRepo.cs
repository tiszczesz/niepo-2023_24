using Microsoft.Data.Sqlite;

namespace cw7;

public class FilmRepo
{
    private string connString = "Data Source=data.db";
    public FilmRepo()
    {
        
    }
    public List<Film> GetFilms(){
        List<Film> films = new List<Film>();
        SqliteConnection conn = new SqliteConnection(connString);
        SqliteCommand command = conn.CreateCommand();
        SqliteCommand command1 = new SqliteCommand();
        conn.Open();
        Console.WriteLine($"Stan polaczenia: {conn.State}");

        conn.Close();
        return films;
    }
}
