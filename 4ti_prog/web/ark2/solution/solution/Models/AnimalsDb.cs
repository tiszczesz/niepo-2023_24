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
            using (MySqlConnection conn = new MySqlConnection(this.connString))
            {

            }

            return animals;
        }
    }

   
}
