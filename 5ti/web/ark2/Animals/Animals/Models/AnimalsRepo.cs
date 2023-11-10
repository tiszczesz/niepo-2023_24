using MySql.Data.MySqlClient;

namespace Animals.Models
{
    public class AnimalsRepo {
        private string connString;

        public AnimalsRepo(string connString) {
            this.connString= connString;
        }

        public List<Animal> GetAnimals() {
            List<Animal> animals = new List<Animal>();
            using (MySqlConnection conn = new MySqlConnection(connString)) {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT id,Gromady_id,gatunek FROM zwierzeta";
                conn.Open();
                MySqlDataReader rd = command.ExecuteReader();
                while (rd.Read()) {
                    animals.Add(
                        new Animal {
                            id = rd.GetInt32(0),
                            gromady_id = rd.GetInt32(1),
                            gatunek = rd.GetString(2)
                        }
                        );
                }

                conn.Close();
            }

            return animals;
        }
        public List<Gromada> GetGromady(){}
    }
}
