import java.sql.SQLException;
import java.util.*;
public interface IRepository {
   // public List<Car> getCars();
    public List<Person> getPersons() throws SQLException;
}
