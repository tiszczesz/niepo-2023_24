namespace cw3;

public class Person
{
    private string firstname;
    private string lastname;
    private DateTime birthDay;
    public Person(string firstname,string lastname,DateTime birthDay)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.birthDay = birthDay;
    }
    public Person(){
         this.firstname = "Adam";
        this.lastname = "Kowalski";
        this.birthDay = new DateTime(2000,1,1);
    }
    public void Show(){
        Console.WriteLine($"Imie: {firstname} Nazwisko: {lastname} Data urodzenia: {birthDay.ToShortDateString()}");
    }
}
