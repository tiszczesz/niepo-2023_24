using MySql.Data.MySqlClient;

namespace Cw2_Ark1.Models
{
    public class WeatherReop
    {
        private string _connString;

        public WeatherReop(string connString)
        {
            _connString = connString;
        }

        public List<WeatherModel> GetWeatherModels()
        {
            List<WeatherModel> weatherList = new List<WeatherModel>();
            using (MySqlConnection conn = new MySqlConnection(_connString))
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = 
                    "SELECT miasta_id,data_prognozy,temperatura_noc,temperatura_dzien,opady,cisnienie "
                    +" FROM pogoda WHERE miasta_id = 2 ORDER BY data_prognozy DESC";
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        weatherList.Add(new WeatherModel
                        {
                            Id = reader.GetInt32(0),
                            DateWeather = reader.GetDateTime(1),
                            TempNight = reader.GetInt32(2),
                            TempDay = reader.GetInt32(3),
                            RainFall = reader.GetInt32(4),
                            Pressure = reader.GetInt32(5),
                           
                        });
                    }
                }

            }
            return weatherList;
        }
    }
}
