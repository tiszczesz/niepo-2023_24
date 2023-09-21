using MySql.Data.MySqlClient;

namespace ark1.Models
{
    public class RepoReaders {
        private string _connString;
        

        public RepoReaders(string connString) {
            _connString = connString;
        }

        public List<Reader> GetAllReaders() {
            List<Reader> readers = new List<Reader>();
            using (MySqlConnection conn = new MySqlConnection(_connString)) {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT id,imie,nazwisko FROM czytelnicy";
                conn.Open();
                MySqlDataReader rd = command.ExecuteReader();
                if (rd != null && rd.HasRows) {
                    while (rd.Read()) {
                        readers.Add(new Reader {
                            Id = rd.GetInt32(0),
                            FirstName = rd.GetString(1),
                            LastName = rd.GetString(2),
                        });
                    }
                }
                
            }
            return readers;
        }

        public void AddReader(Reader reader)
        {
            using (MySqlConnection conn = new MySqlConnection(_connString))
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO czytelnicy(imie,nazwisko, kod)"
                                      +" VALUES(@firstname,@lastname,@code)";
                command.Parameters.Add("@firstname", MySqlDbType.String).Value = reader.FirstName;
                command.Parameters.Add("@lastname", MySqlDbType.String).Value = reader.LastName;
                command.Parameters.Add("@code", MySqlDbType.String).Value = reader.Code;
                command.ExecuteNonQuery();


            }
        }
    }
}
