import java.util.ArrayList;
import java.util.List;

public class FakeRepo implements IRepository {
    @Override
    public List<Person> getPersons() {
        ArrayList<Person> people = new ArrayList<Person>();
        people.add(new Person("Jan", "Kowalski"));
        people.add(new Person("Anna", "Nowak"));
        people.add(new Person("Piotr", "Wiśniewski"));
        return people;
    }
}
