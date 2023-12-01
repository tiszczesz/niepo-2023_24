
using MySql.Data.MySqlClient;

namespace cw3_empty_api;

public class MysqlStudentRepo : IStudentRepo
{
    private string _connString;
    public MysqlStudentRepo(string connString)
    {
        _connString = connString;
    }
    public List<Student> GetAll()
    {
        List<Student> students = new List<Student>();
        using (MySqlConnection conn = new MySqlConnection(_connString))
        {
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM students";
            conn.Open();
            MySqlDataReader rd = command.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    students.Add(
                        new Student
                        {
                            Id = rd.GetInt32(0),
                            Firstname = rd.GetString(1),
                            Lastname = rd.GetString(2),
                            MyDate = rd.GetDateTime(3)
                        }
                    );
                }
            }
            conn.Close();
        }
        return students;
    }

    public Student? GetById(int? id)
    {       
        using (MySqlConnection conn = new MySqlConnection(_connString))
        {
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = $"SELECT * FROM students WHERE id={id}";
            conn.Open();
            MySqlDataReader rd = command.ExecuteReader();

            if (rd.HasRows)
            {
                rd.Read();
               return new Student{
                 Id = rd.GetInt32(0),
                            Firstname = rd.GetString(1),
                            Lastname = rd.GetString(2),
                            MyDate = rd.GetDateTime(3)
               };                       
            }
            conn.Close();
        }
        return null;
    }

    public void Insert(Student s)
    {
        using(MySqlConnection conn = new MySqlConnection(_connString)){
            MySqlCommand command = conn.CreateCommand();
            var myData = s.MyDate.ToString("yyyy-MM-dd");
            command.CommandText = 
            $"INSERT INTO students (firstname, lastname, mydate) VALUES ('{s.Firstname}', '{s.Lastname}', '{myData}')";
            Console.WriteLine(command.CommandText);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }

    
    
}
