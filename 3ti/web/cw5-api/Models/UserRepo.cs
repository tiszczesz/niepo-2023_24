
using Microsoft.Data.Sqlite;

namespace cw5_api;

public class UserRepo : IUserRepo
{
    private  string _connString;
    public UserRepo(string connString)
    {
        this._connString = connString;
    }
    public int Delete(int? id)
    {
        throw new NotImplementedException();
    }

    public User? GetUser(int? id)
    {
        throw new NotImplementedException();
    }

    public List<User> GetUsers()
    {
        List<User> users = new List<User>();
        using (SqliteConnection connection = new SqliteConnection(_connString))
        {
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM users";
            connection.Open();
            SqliteDataReader rd = command.ExecuteReader();
            while (rd.Read())
            {
                users.Add(
                    new User
                    {
                        Id = rd.GetInt32(0),
                        Firstname = rd.GetString(1),
                        Lastname = rd.GetString(2),
                        MyDate = rd.GetDateTime(3)
                    }
                    );
            }
            connection.Close();
        }

        return users;
    }

    public void Insert(User user)
    {
        throw new NotImplementedException();
    }

    public int Update(int? id, User user)
    {
        throw new NotImplementedException();
    }
}
