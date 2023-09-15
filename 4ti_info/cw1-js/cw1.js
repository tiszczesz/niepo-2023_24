const Book1 = {
    //pola obiektu lub właściwości
    title: "ABC programowania obiektowego w JS",
    author: "Marian Zagórny",
    price: 45.99,

    //metody obiektu
    show: function () {
        return `
            <h4>Tytuł: ${this.title}</h4>
            <h5>Autor: ${this.author}</h5>
            <h6>Cena: ${this.price} zł</h6>
        `;
    },
    setPrice: function (price) {
        this.price = price;
    }
}
const Film1 = {
    //pola obiektu lub właściwości
    title: "Wakacje w górach",
    director: "Anna Franuk",
    length: 140,
    language: "polski",
    //metody obiektu
    showFilm: function () {
        return `
            <h4>Tytuł: ${this.title}</h4>
            <h5>Reżyser: ${this.director}</h5>
            <h6>Długość filmu: ${this.length} min</h6>
            <h6>Język: ${this.language}</h6>
        `;
    }
}
function Game(title, genre, price, year) {
    //pola obiektu
    this.title = title;
    this.genre = genre;
    this.price = price;
    this.year = year;
    //metody obiektu
    this.info = function () {
        return `
        <div class="card" style="width: 18rem;"> 
            <h4 class="card-title bg-primary-subtle">${this.title}</h4> 
                <div class="card-body">        
                    <h6 class="card-text">Rodzaj gry: ${this.genre}</h6>
                    <h6 class="card-text">Cena gry: ${this.price} zł</h6>
                    <div class="card-text">Rok wydania gry: ${this.year}</div>
                </div>
        </div>
        `
        }
}
const g1 = new Game("FIFA 2023","sportowa",120,2022); //utworzenie obiektu gra
const g2 = new Game("Cyberpunk 2077","RPG",90,2021); //utworzenie obiektu gra
document.querySelector("#p1").innerHTML = Book1.show();
document.querySelector("#p2").innerHTML = Film1.showFilm();
document.querySelector("#p3").innerHTML = g1.info();
document.querySelector("#p4").innerHTML = g2.info();