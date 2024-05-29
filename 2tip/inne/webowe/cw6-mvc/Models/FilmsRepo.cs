using Microsoft.Data.Sqlite;

namespace cw6_mvc.Models;

public class FilmsRepo
{
    private readonly string? _connString;
    public FilmsRepo(IConfiguration configuration)
    {
        _connString = configuration.GetConnectionString("sqlite");
    }
    public List<Film> GetFilms()
    {
        var films = new List<Film>();
        using (var conn = new SqliteConnection(_connString))
        {
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM  Films";
            conn.Open();
            SqliteDataReader rd = command.ExecuteReader();
            while (rd.Read())
            {
                films.Add(
                    new Film
                    {
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

    public void InserFilm(Film? film)
    {
        if (film == null) return;
        using (SqliteConnection connection = new SqliteConnection(_connString))
        {
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Films(title,director,year,price)"
            + " VALUES(@title,@director,@year,@price)";
            command.Parameters.AddWithValue("@title", film.Title);
            command.Parameters.AddWithValue("@director", film.Director);
            command.Parameters.AddWithValue("@year", film.Year);
            command.Parameters.AddWithValue("@price", film.Price);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
