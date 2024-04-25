import kotlin.random.Random

fun main(){
   // var howMany:Int
  //  print("Podaj ile liczb: ")
  //  howMany = readln().toInt()
    //zad1(howMany)
   // zad2(howMany)
    zad3()
    println( isPrimal(33))
}
fun zad1(howMany:Int){
    //20 liczb losowych petla for
    val rnd = Random(100)
    for (i in 1..howMany){
        print("${rnd.nextInt(10,100)} ")
    }
}
//napisac funkcje wyswietlajaca liczby losowe z dopiskiem parzyste lub nie
fun zad2(howMany: Int){
    val rnd = Random(100)
    var number:Int
    var napis:String
    for (i in 1..howMany){
        number = rnd.nextInt(0,100)
//        if(number%2==0){
//            println("$number jest parzysta")
//        }else{
//            println("$number jest nieparzysta")
//        }
        napis = if(number%2==0) "$number parzysta" else "$number nieparzysta"
        println(napis)
    }
}
fun zad3(){
    val items = listOf("red","green","blue","yellow","other") //niemutowalna lista
    for (color in items){
        print("$color ")
    }
    println("\n---------------------------------------")
    var items2 = mutableListOf("rrrr","ttttt") //mutowalna lista
    items2.add("nowy");
    for (i in items2){
        print("$i ")
    }
    items2.count()
    println("\n---------------------------------------")
}
//napisac funkcje generujaca liste liczb losowych pierwszych o ustalonym rozmiarze
//fun generPrimals()
fun isPrimal(number:Int):Boolean {
    if(number<2) return false
    var i:Int=1
    while (i*i<=number){
        i++
        if(number%i==0) return false
    }
    return true
}