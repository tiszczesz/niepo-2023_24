namespace cw14_mvc.Models;

public class StudentRepo
{
    public static List<Student> GetStudents()
    {
        return new List<Student> {
            new Student {Id = 1,FirstName="Roman",LastName="Nowak",Age=23},
            new Student {Id = 2,FirstName="Monika",LastName="Młyn",Age=12},
            new Student {Id = 3,FirstName="Teresa",LastName="Redecka",Age=45},
            new Student {Id = 4,FirstName="Jerzy",LastName="Kowalski",Age=32},
            new Student {Id = 5,FirstName="Tomasz",LastName="Nowak",Age=19},
            new Student {Id = 6,FirstName="Eryk",LastName="Nowak",Age=20},
            new Student {Id = 7,FirstName="Monika",LastName="Dzika",Age=27}
        };
    }
}
