namespace cw3_empty_api;

public interface IStudentRepo
{
    int Delete(int? id);
    List<Student> GetAll();
    Student? GetById(int? id);
    void Insert(Student student);
    int Update(int? id,Student student);

}
