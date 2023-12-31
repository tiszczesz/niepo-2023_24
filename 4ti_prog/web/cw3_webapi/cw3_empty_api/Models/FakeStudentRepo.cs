﻿namespace cw3_empty_api;

public class FakeStudentRepo : IStudentRepo
{
    private readonly List<Student> _students;

    public FakeStudentRepo(string fake)
    {
        _students = new List<Student>{
            new Student{Id=1,Firstname="Adam",Lastname="Nowak"},
            new Student{Id=2,Firstname="Grażyna",Lastname="Małecka"
             ,MyDate=new DateTime(2006,9,12)},
            new Student{Id=3,Firstname="Monika",Lastname="Kika",
              MyDate=new DateTime(2005,7,22)},
            new Student{Id=4,Firstname="Roman",Lastname="Boman",
            MyDate=new DateTime(2012,3,21)},
        };
    }

    public int Delete(int? id)
    {
        throw new NotImplementedException();
    }

    public List<Student> GetAll()
    {
        return _students;
    }

    public Student? GetById(int? id)
    {
        return _students.FirstOrDefault(s => s.Id == id);
    }

    public void Insert(Student student)
    {
        throw new NotImplementedException();
    }

    public int Update(int? id, Student student)
    {
        throw new NotImplementedException();
    }
}
