namespace cw3;

public class Person
{
    private string firstname;
    private string lastname;
    private DateTime birthDay;
    public Person(string firstname,string lastname,DateTime birthDay)//przeciazanie konstruktorow
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.birthDay = birthDay;
    }
    public Person(){   //przeciazanie konstruktorow
         this.firstname = "Adam";
        this.lastname = "Kowalski";
        this.birthDay = new DateTime(2000,1,1);
    }
    
    override public string? ToString(){ //nadpisanie Tostring z Object!!!!
        return $"Nadpisane!!!! Imie: {firstname} Nazwisko: {lastname} Data urodzenia: {birthDay.ToShortDateString()}";
    }
    public void Show(){
        Console.WriteLine($"Imie: {firstname} Nazwisko: {lastname} Data urodzenia: {birthDay.ToShortDateString()}");
    }
}
