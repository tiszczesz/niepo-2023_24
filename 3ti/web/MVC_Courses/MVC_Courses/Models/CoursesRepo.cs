using MySql.Data.MySqlClient;

namespace MVC_Courses.Models
{
    public class CoursesRepo {
        private string _connString;

        public CoursesRepo(string connString) {
            _connString = connString;
        }

        public List<Division> GetDivisions() {
            List<Division> divisions = new List<Division>();
            using (MySqlConnection conn = new MySqlConnection(_connString)) {
                MySqlCommand command = conn.CreateCommand();
                //todo
                conn.Open();
            }

            return divisions;
        }
    }
}
