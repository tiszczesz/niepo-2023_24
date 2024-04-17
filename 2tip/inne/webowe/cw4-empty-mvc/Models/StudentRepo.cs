namespace cw4_empty_mvc.Models;

public class StudentRepo{
    public static List<Student> GetStudents(){
        return new List<Student>{
            new Student{Firstname="Adam",Lastname="Nowak",Age=22},
            new Student{Firstname="Monika",Lastname="Tryk",Age=22},
            new Student{Firstname="Roman",Lastname="Małecki",Age=22},
            new Student{Firstname="Renata",Lastname="Truk",Age=22},
            new Student{Firstname="Tomasz",Lastname="Nowak",Age=22},
        };
    }
} 