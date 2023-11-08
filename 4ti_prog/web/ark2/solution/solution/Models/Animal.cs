namespace solution.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string? Genre { get; set; }
        public string? Place { get; set; }
        public bool IsDanger { get; set; }
        public string? ImageName { get; set; }
        public int AnimalClass_id { get; set; }
        public int Food_id { get; set; }
    }
}
