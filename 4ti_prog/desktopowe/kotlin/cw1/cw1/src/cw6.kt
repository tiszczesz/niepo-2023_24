import java.io.File

fun main(){
    readFile("dane.txt");

    val lines = reafFileToList("dane.txt")
    var index=0;
    for (line in lines){
        index++;
        println("Linia tekstu nr: ${index} --->  ${line}")
    }
    println(" ---------------------------------------------- ")
    print("Podaj tekst: ")
    val tekst = readln()
    println("tekst: ${tekst}")
    println("-------------------------------------------")
    print("Podaj tekst: ");
    val text = readln();
    println("Ilość cyfr w tekście: $text -> ${HowManyDigits(text)}")
}

fun readFile(fileName:String){
    return File(fileName).forEachLine {it -> println(it) }
}
fun reafFileToList(fileName: String):List<String>{
    return File(fileName).useLines { it->it.toList() }
}
fun HowManyDigits(data:String):Int{
    return data.count{it->it.isDigit()}
}