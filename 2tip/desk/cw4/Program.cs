Ex1();
Ex2();

void Ex2()
{
   //Napisac aplikacje która prosi użytkownika o podawanie 
   //kolejnych lini tekstu
   //aż do momentu napisania koniec
   //wszystko zapisuje sie do List<string>
   //potem zapis do pliku
   //następnie odczyt z pliku
}

void Ex1()
{
    List<string> words = new List<string>{
        "Ala ma kota",
        "druga linijka tekstu",
        "i jeszcze coś ciekawego"
    };
    File.WriteAllLines("data2.txt", words);
    var wiadro = File.ReadAllLines("data.txt");
    foreach (string line in wiadro)
    {
        Console.WriteLine(line);
    }
}