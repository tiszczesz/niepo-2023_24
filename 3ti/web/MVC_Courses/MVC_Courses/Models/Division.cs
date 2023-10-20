namespace MVC_Courses.Models
{
    public class Division
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Teacher_Id { get; set; }

        public Teacher? MyTeacher { get; set; } = null;
    }
}
