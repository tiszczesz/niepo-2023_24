class Book(private val title:String,private val author:String,private val price:Double) {
    var fullInfo: String
        get() {
            return "Tytuł: ${this.title} autor: ${this.author} cena: ${this.price} zł"
        }
    init {
        println("Tworzenie obiektu Book");
        fullInfo = ""
    }
    constructor():this("noname","noname",0.0){
        println("Konstruktor bez argumentów")
    }
}
