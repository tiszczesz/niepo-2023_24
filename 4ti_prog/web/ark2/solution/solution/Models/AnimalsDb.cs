using MySql.Data.MySqlClient;

namespace solution.Models
{
    public class AnimalsDb
    {
        private readonly string connString;

        public AnimalsDb(string connString) {
            this.connString = connString;
           
        }

        public List<Animal> GetAllAnimals() {
            List<Animal> animals = new List<Animal>();
            using (MySqlConnection conn = new MySqlConnection(this.connString)) {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT id,Gromady_id,Odzywianie_id,gatunek,wystepowanie, "
                                      + "czy_zagrozony,obraz FROM zwierzeta";
                conn.Open();
                MySqlDataReader rd = command.ExecuteReader();
                while (rd.Read()) {
                    animals.Add(new Animal {
                        Id = rd.GetInt32(0),
                        AnimalClass_id = rd.GetInt32(1),
                        Food_id = rd.GetInt32(2),
                        Genre = rd.GetString(3),
                        Place = rd.GetString(4),
                        IsDanger = rd.GetBoolean(5),
                        ImageName = rd.GetString(6)
                    });
                }
                conn.Close();
            }
            return animals;
        }

        public List<AnimalClass> GetAnimalClasses() {
            List<AnimalClass> animalClasses = new List<AnimalClass>();
            using (MySqlConnection conn = new MySqlConnection(this.connString))
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "";
                conn.Open();
                MySqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                }
                conn.Close();
            }
            return animalClasses;
        }
    }

   
}
