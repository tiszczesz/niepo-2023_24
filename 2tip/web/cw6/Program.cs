// aplikacja z menu  do ... while
// 1 - dodaj nowy film title, director, price, length, year, language/s
//    dodawanie oboektu film do listy
//      zapis do pliku
// 2 - wyswietl wszystkie filmy popbranie z pliku
// 3 -  zakoncz program   ----  ambitnie moga dorobic usuwanie filmu
// title;director;price;length;year;language/s
// title;director;price;length;year;language/s
using cw6;
ShowMenu();
void ShowMenu()
{
    char? choice = 'k';
    do 
    {
        Console.WriteLine("  ====== FILMOTEKA =================\n");
        Console.WriteLine("1\tDodaj nowy film:");
        Console.WriteLine("2\twyswietl wszystkie filmy:");
        Console.WriteLine("k\tZakończ program:");
        Console.Write("\nWybierz opcje:\t--->\t");
        string? answer = Console.ReadLine();
        choice = (answer!=null && answer?.Length>0) ? answer.ToLower()[0]:'g';
        switch(choice){
            case '1': AddFilm(); break;
            case '2': ShowallFilms(); break;
            case 'k':break;            
        }
    }while(choice != 'k');

}

void ShowallFilms()
{
    Console.WriteLine("Wyswietlanie wszystkich filmow....");
}

void AddFilm()
{
   Console.WriteLine("dodawanie filmu....");
}

// var film1 = new Film()
// {
//     Title = "dgdfgdfgdfg",
//     Price = 23.6m
// };
// File.AppendAllText("ffff.txt", film1.ToLine());
// void Test(List<string> ggg = null)
// {
//     if (ggg == null)
//     {
//         ggg = new List<string> { };
//     }
// }