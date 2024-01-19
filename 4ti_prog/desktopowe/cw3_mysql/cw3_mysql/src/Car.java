public class Car {
    public int Id;
    private String Firstname;
    private String Lastname;

    public int getId() {
        return Id;
    }

    public void setId(int id) {
        Id = id;
    }

    public String getFirstname() {
        return Firstname;
    }

    public void setFirstname(String firstname) {
        Firstname = firstname;
    }

    public String getLastname() {
        return Lastname;
    }

    public void setLastname(String lastname) {
        Lastname = lastname;
    }

    public Car(int id, String firstname, String lastname) {
        Id = id;
        Firstname = firstname;
        Lastname = lastname;
    }
}
