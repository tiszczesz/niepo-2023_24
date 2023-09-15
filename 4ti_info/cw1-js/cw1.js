const Book1 = {
    //pola obiektu lub właściwości
    title: "ABC programowania obiektowego w JS",
    author: "Marian Zagórny",
    price: 45.99,    

    //metody obiektu
    show: function(){
        return `
            <h4>Tytuł: ${this.title}</h4>
            <h5>Autor: ${this.author}</h5>
            <h6>Cena: ${this.price} zł</h6>
        `;
    },
    setPrice: function(price){
        this.price = price;
    }
}
const Film1 = {
    //pola obiektu lub właściwości
    title: "Wakacje w górach",
    director: "Anna Franuk",
    length: 140,
    language:"polski",
    //metody obiektu
    showFilm: function(){
        return `
            <h4>Tytuł: ${this.title}</h4>
            <h5>Reżyser: ${this.director}</h5>
            <h6>Długość filmu: ${this.length} min</h6>
            <h6>Język: ${this.language}</h6>
        `;
    }    
}

document.querySelector("#p1").innerHTML = Book1.show();
document.querySelector("#p2").innerHTML = Film1.showFilm();