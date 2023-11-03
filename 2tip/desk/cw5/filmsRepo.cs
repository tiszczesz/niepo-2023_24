
using Microsoft.Data.Sqlite;

namespace cw5;

public class FilmsRepo
{
    private string dbName = "films.db";
    private string connString;
    public FilmsRepo()
    {     
        connString =  $"Data Source={System.IO.Path.Join(AppContext.BaseDirectory,dbName)}";  
    }

    public List<Film> GetAllFilms(){
        List<Film> films = new List<Film>();
        SqliteConnection connection = new SqliteConnection(connString);
        connection.Open();
        Console.WriteLine(connection.State);

        connection.Close();
        return films;
    }

}

