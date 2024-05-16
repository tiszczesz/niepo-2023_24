class Book(private val title:String,private val author:String,private val price:Double=0.0) {
    var fullInfo: String
        get() {
            return "Tytuł: ${this.title} autor: ${this.author} cena: ${this.price} zł"
        }
    init {
        println("Tworzenie obiektu Book");
        fullInfo = ""
    }
    constructor():this("noname","noname"){
        println("Konstruktor bez argumentów")
    }
}
