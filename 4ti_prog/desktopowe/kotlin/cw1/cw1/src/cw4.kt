fun main(){
    val list = generateList();
    for (person in list){
        println("${person.firstname} ${person.lastname} wiek: ${person.age}")
    }
}
data class Person(var firstname:String,var lastname:String,var age:Int)

fun generateList():ArrayList<Person>{
    return arrayListOf<Person>(
        Person("Jan", "Kowalski", 30),
        Person("Anna", "Nowak", 25),
        Person("Piotr", "Nowicki", 40)
    )
}