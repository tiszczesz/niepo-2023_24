// aplikacja z menu  do ... while
// 1 - dodaj nowy film title, director, price, length, year, language/s
//    dodawanie oboektu film do listy
//      zapis do pliku
// 2 - wyswietl wszystkie filmy popbranie z pliku
// 3 -  zakoncz program   ----  ambitnie moga dorobic usuwanie filmu
// title;director;price;length;year;language/s
// title;director;price;length;year;language/s


using cw6;

var film1 = new Film(){
    Title = "dgdfgdfgdfg",
    Price = 23.6m
};
File.AppendAllText("ffff.txt",film1.ToLine());
void Test(List<string> ggg=null){
    if(ggg==null){
        ggg = new List<string>{};
    }
}