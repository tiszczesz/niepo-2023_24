fun main() {
    println("Hello World!");
    print("dsf sf dsf dsfdsfds")
    print("-----------------\n")
    println(hello("Ryba"))
    println(welcome("Roman","Boman",22))
    println(welcome("Monika","Małecka",22))
}
fun hello(message:String):String{
    return "To jest zwrotna informacja z funkcji: $message"
}
fun welcome(firstname:String,lastname:String,age:Int?):String{
    return " -----------------------------   \n" +
      "    $firstname $lastname  \n" +
            "   Twój wiek: $age    \n" +
            " -------------------------------   "
}