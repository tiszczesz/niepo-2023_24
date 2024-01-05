var firstname: string = "Janusz";
//firstname = 45;
function Hello(firstname: string, lastname: string, age = 20): string {
    return `Imię: ${firstname}\nNazwisko: ${lastname}\nWiek: ${age}\n--------------`;
}
console.log(firstname, typeof firstname);
console.log(Hello("Adam", "Nowak", 67));
console.log(Hello("Adek", "Nowacki"));
//fun Register(imie,nazwisko,data ukonczenia kursu,wiek)
//Register zwraca true jesli data ukonczenia mniejsza niz NOW i wiek>=18
//gdy rejaestracja OK to data egzaminu na dzisiaj + 1 tydzien
const dd :Date = new Date();
console.log(dd.toLocaleDateString());
//Register("Jan","Nowak",new Date(rok,miesiac,dzien),17)