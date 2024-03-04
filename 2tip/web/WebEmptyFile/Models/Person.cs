namespace WebEmptyFile.Models
{
    public class Person
    {
        public Person() {
            Id = new Guid().ToString();
        }
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Content { get; set; }
        public DateOnly PartyDate { get; set; }
    }
}
