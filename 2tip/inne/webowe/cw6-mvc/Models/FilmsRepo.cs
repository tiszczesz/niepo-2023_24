using Microsoft.Data.Sqlite;

namespace cw6_mvc.Models;

public class FilmsRepo
{
    private readonly string? _connString;
    public FilmsRepo(IConfiguration configuration){
        _connString = configuration.GetConnectionString("sqlite");
    }
    public List<Film> GetFilms(){
        var films = new List<Film>();
        using (var conn = new SqliteConnection(_connString)){
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM  Films";
            conn.Open();
            SqliteDataReader rd = command.ExecuteReader();
            while (rd.Read()){
                films.Add(
                    new Film{
                        Id = rd.GetInt32(0),
                        Title = rd.GetString(1),
                        Director = rd.GetString(2),
                        Year = rd.GetInt32(3),
                        Price = rd.GetDecimal(4)
                    }
                );
            }
        }       
       return films; 
    }

    public void InserFilm()
    {
        throw new NotImplementedException();
    }
}
