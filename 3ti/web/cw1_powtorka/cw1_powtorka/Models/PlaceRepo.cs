using MySql.Data.MySqlClient;

namespace cw1_powtorka.Models
{
    public class PlaceRepo {
        private string _connString;

        public PlaceRepo(string connString) {
            _connString = connString;
        }

        public List<Place> GetPlaces() {
            List<Place> places = new List<Place>();
            using (MySqlConnection conn = new MySqlConnection(_connString)) {
                conn.Open();
            }

            return places;
        }
    }
}
