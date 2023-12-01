namespace cw3_empty_api;

public interface IStudentRepo
{
    List<Student> GetAll();
    Student? GetById(int? id);
    void Insert(Student student);

}
