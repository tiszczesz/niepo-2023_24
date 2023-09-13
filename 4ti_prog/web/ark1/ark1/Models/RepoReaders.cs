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

        internal void AddReader(Reader reader)
        {
            throw new NotImplementedException();
        }
    }
}
