namespace cw3_razor_vs.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int? Age { get; set; }
        public DateOnly? Birthday { get; set; }
    }
}
