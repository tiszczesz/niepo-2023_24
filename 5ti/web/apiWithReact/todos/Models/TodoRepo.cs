using MySql.Data.MySqlClient;

namespace todos.Models
{
    public class TodoRepo
    {
        private readonly string connString;

        public TodoRepo(string connString)
        {
            this.connString = connString;
        }

        public List<Todo> GetAll()
        {
            List<Todo> todos = new List<Todo>();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM todos";
                conn.Open();
                MySqlDataReader rd = command.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        todos.Add(
                            new Todo
                            {
                                Id = rd.GetInt32(0),
                                Content = rd.GetString(1),
                                IsCompleted = rd.GetBoolean(2)
                            }
                            );
                    }
                }
                conn.Close();
            }

            return todos;
        }

        public Todo? GetByIdTodo(int? id)
        {
            if (id == null) return null;
            Todo todo = null;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {

                MySqlCommand command = conn.CreateCommand();
                command.CommandText = $"SELECT * FROM todos WHERE id={id}";
                conn.Open();
                MySqlDataReader rd = command.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    todo = new Todo
                    {
                        Id = rd.GetInt32(0),
                        Content = rd.GetString(1),
                        IsCompleted = rd.GetBoolean(2)
                    };

                }
                conn.Close();
            }

            return todo;
        }
        public void Insert(Todo todo)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText =
                  $"INSERT INTO todos (content, isCompleted) VALUES ('{todo.Content}', {todo.IsCompleted})";
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }


        }

        public void Delete(int? id)
        { 
            if(id==null) return;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
               
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = $"DELETE FROM todos WHERE id={id}";
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void Update(int? id, Todo todo)
        {
            if(id==null) return;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText =
                   $"UPDATE todos SET content='{todo.Content}', isCompleted={todo.IsCompleted} WHERE id={id}";
                conn.Open();                
                command.ExecuteNonQuery();
                conn.Close();
            }
            
        }
    }
}
