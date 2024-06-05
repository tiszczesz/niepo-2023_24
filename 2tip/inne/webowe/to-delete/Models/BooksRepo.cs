using MySql.Data.MySqlClient;

namespace to_delete;

public class BooksRepo
{
    private string? _connString;
    public BooksRepo(IConfiguration configuration)
    {
        _connString = configuration.GetConnectionString("mysqlConn");
    }
    public List<Book> GetAll(){
        var books = new List<Book>();
        using (MySqlConnection connection = new MySqlConnection(_connString) )
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM books";
            connection.Open();
            MySqlDataReader rd = command.ExecuteReader();
            while (rd.Read()){
                books.Add(new Book{
                    Id = rd.GetInt32(0),
                    Title = rd.GetString(1),
                    Author = rd.GetString(2),
                    Price = rd.GetDecimal(3),
                });
            }
            connection.Close();
        }
        
        return books;        
    }
    public void Delete(int? id){
         using (MySqlConnection connection = new MySqlConnection(_connString) )
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM books WHERE id={id}";
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
