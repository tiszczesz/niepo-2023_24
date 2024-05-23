// Abstrakcyjna klasa Person
abstract class PersonAbs(val name: String, val age: Int) {
    init {
        println("Klasa abstrakcyjna PersonAbs")
    }
    abstract fun getDescription(): String
}

// Interfejs Workable
interface Workable {
    fun work()
}

// Klasa Student dziedzicząca po Person i implementująca Workable
class Student(name: String, age: Int, val studentId: String) : PersonAbs(name, age), Workable {
    init {
        println("Klasa Student")
    }
    override fun getDescription(): String {
        return "Student: $name, Age: $age, Student ID: $studentId"
    }

    override fun work() {
        println("$name is studying.")
    }
}

// Klasa Worker dziedzicząca po Person i implementująca Workable
class Worker(name: String, age: Int, val jobTitle: String) : PersonAbs(name, age), Workable {
    init {
        println("Klasa Worker")
    }
    override fun getDescription(): String {
        return "Worker: $name, Age: $age, Job Title: $jobTitle"
    }

    override fun work() {
        println("$name is working as a $jobTitle.")
    }
}

// Przykładowe użycie
fun main() {
    val student = Student("Alice", 21, "S12345")
    val worker = Worker("Bob", 30, "Engineer")

    println(student.getDescription())
    student.work()

    println(worker.getDescription())
    worker.work()
}
