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
                conn.Open();
            }
            return readers;
        }
    }
}
