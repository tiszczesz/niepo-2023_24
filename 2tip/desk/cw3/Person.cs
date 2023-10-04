namespace cw3;
/*
1. Hermatyzacja danych ---> ukrywanie
2. Dziedziczenie ---> korzystanie z klas bazowych w klasach pochdnych Object ---> Person
3. Polimorfizm uzywanie obiektow klas pochodnych w miejscach klas bazowych
4. Abstrakcja przelozenie wybranych cech do klas abstrakcyjnych

przeciazanie metod o tej samej nazwie w tej samej klasie np konstruktory
nadpisywanie metod z klasy bazowej w klasie pochodniej   ToString() z Object w Person

*/
public class Person
{
    private string firstname;
    private string lastname;
    private DateTime birthDay;
    public Person(string firstname,string lastname,DateTime birthDay)//przeciazanie konstruktorow
    {
        Firstname = firstname;
        Lastname = lastname;
        BirthDay = birthDay;
    }
    public Person(){   //przeciazanie konstruktorow
        Firstname = "Adam";
        Lastname = "Kowalski";
        BirthDay = new DateTime(2000,1,1);
    }
    public string Place { get; set; } //miejsce  autoproperty
    
    override public string? ToString(){ //nadpisanie Tostring z Object!!!!
        return $"Nadpisane!!!! Imie: {firstname} Nazwisko: {lastname} Data urodzenia: {birthDay.ToShortDateString()}";
    }
    public void Show(){
        Console.WriteLine($"Imie: {firstname} Nazwisko: {lastname} Data urodzenia: {birthDay.ToShortDateString()}");
    }
    // public override int GetHashCode()
    // {
    //     return 999999;
    // }
    public int GetAge(){
        //return DateTime.Now.Year - birthDay.Year;
        return (DateTime.Now - birthDay).Days/365;
    }
    // public void  SetFirstname(string firstname){
    //     this.firstname = firstname.ToUpper();
    // }

    //proprty
    public string Firstname{
        get{
            return firstname;
        }
        set{
            firstname = value.ToUpper();
        }
    }
    public string Lastname{
        get{
            return lastname;
        }
        set{
            lastname = value.ToUpper();
        }
    }
    public DateTime BirthDay{
        get{
            return birthDay;
        }
        set{
            birthDay = value;
        }
    }
}
