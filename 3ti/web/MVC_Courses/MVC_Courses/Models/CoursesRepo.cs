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

        public List<Student> GetStudents(int? id) {
            List<Student> students = new List<Student>();
            using (MySqlConnection conn = new MySqlConnection(_connString))
            {
                MySqlCommand command = conn.CreateCommand();
                //string sqlQuery = "SELECT * FROM divisions";
                string sql = id == null
                    ? "SELECT * FROM student"
                    : $"SELECT * FROM student where division_id={id}";
                command.CommandText = sql;
                conn.Open();
                MySqlDataReader rd = command.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                       students.Add(
                           new Student {
                               Id = rd.GetInt32(0),
                               Firstname = rd.GetString(1),
                               Lastname = rd.GetString(2),
                               Division_id = rd.GetInt32(3)
                           }
                           );
                    }
                }
                conn.Close();
            }

            return students;
        }
    }
}
