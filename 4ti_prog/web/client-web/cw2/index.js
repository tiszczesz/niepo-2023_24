var firstname = "Janusz";
//firstname = 45;
function Hello(firstname, lastname, age) {
    if (age === void 0) { age = 20; }
    return "Imi\u0119: ".concat(firstname, "\nNazwisko: ").concat(lastname, "\nWiek: ").concat(age, "\n--------------");
}
console.log(firstname, typeof firstname);
console.log(Hello("Adam", "Nowak", 67));
console.log(Hello("Adek", "Nowacki"));
//fun Register(imie,nazwisko,data ukonczenia kursu,wiek)
//Register zwraca true jesli data ukonczenia mniejsza niz NOW i wiek>=18
var dd = new Date();
console.log(dd.toLocaleDateString());
