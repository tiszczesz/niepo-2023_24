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
                //string sqlQuery = "SELECT * FROM divisions";
                command.CommandText = "SELECT * FROM divisions";
                conn.Open();
                MySqlDataReader rd = command.ExecuteReader();
                if (rd.HasRows) {
                    while (rd.Read()) {
                        divisions.Add(
                            new Division {
                                Id = rd.GetInt32(0),
                                Name = rd.GetString(1), 
                                Teacher_Id = rd.GetInt32(2)
                            }
                            );
                    }
                }
                conn.Close();
            }

            return divisions;
        }
    }
}
