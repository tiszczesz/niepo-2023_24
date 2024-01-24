import java.sql.*;
import java.util.ArrayList;
import java.util.List;

public class MySqlRepo  implements IRepository{

    @Override
    public List<Person> getPersons()  {
        ArrayList<Person> persons = new ArrayList<>();
        try {
            Connection connection = DriverManager.getConnection(
                    "jdbc:mysql://localhost:3306/4ti_persons",
                    "root", "");
            Statement std = connection.createStatement();
            ResultSet resultSet = std.executeQuery("SELECT firstname, lastname from persons");

            while (resultSet.next()){
                String firstname = resultSet.getNString("firstname");
                String lastname = resultSet.getNString("lastname");
                Person person = new Person(firstname,lastname);
                persons.add(person);
            }
            connection.close();
        } catch (SQLException e) {
            return null;
        }
        return persons;


    }
}
