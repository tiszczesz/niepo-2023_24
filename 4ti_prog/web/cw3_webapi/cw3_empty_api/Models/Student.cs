namespace cw3_empty_api;

public class Student
{
    public int Id { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public DateTime MyDate { get; set; }=DateTime.Now;
}
