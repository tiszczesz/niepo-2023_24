class Game {
    constructor(title,genre,price,year){
        this.title = title;
        this.genre = genre;
        this.price = price;
        this.year = year;
    }
    show(){
        return `
         <div class="card m-2">
         <div class="card-body">
         <h5 class="card-title">${this.title}</h5>
         <h6> Gatunek: ${this.genre}</h6>
         <p class="card-text">
            Cena gry: <span class="fw-bold text-success">${this.price} zł</span>
            Rok wydania <span class="fw-bold text-success">${this.year}</span>
         </p>
       </div>     
         </div>
        `
    }
}

const g1 = new Game("Wiedźmin 3","RPG",59.69,2015);
const g2 = new Game("FIFA 2022","sportowa",89.69,2015);
const games = [
    new Game("Wiedźmin 3","RPG",59.69,2015),
    new Game("FIFA 2022","sportowa",89.69,2015),
    new Game("Cyberpunk 2077","RPG",89.69,2021),
    new Game("Minecraft","symulator",55.99,2017),
];
let html = "<div class='d-flex justify-content-around'>";
for(let i=0; i<games.length;i++){
    html += games[i].show();
}
html += "</div>";
document.querySelector("#p1").innerHTML = html;