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
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT id, nazwa, cena, termin FROM miejsca";
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader != null && reader.HasRows) {
                    while (reader.Read()) {
                        places.Add(new Place {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Price = reader.GetDecimal(2),
                            DateStart = reader.GetDateTime(3)
                        });
                    }
                }
                
            }
            return places;
        }
    }
}
