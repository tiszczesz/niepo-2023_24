public class Message {
    private String firstname;
    private String lastname;

    public Message(String firstname, String lastname) {
        this.firstname = firstname;
        this.lastname = lastname;
    }

    public Message() {
        firstname = "noname";
        lastname = "noname";
    }

    @Override
    public String toString() {
        return "Imie: "+firstname+" Nazwisko: "+lastname;
    }

    public String getFirstname() {
        return firstname;
    }

    public String getLastname() {
        return lastname;
    }
}
