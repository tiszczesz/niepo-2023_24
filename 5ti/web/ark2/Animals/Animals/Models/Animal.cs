namespace Animals.Models
{
    public class Animal
    {
        public int id { get; set; }
        public int? gromady_id { get; set; }
        public int? odzywianie_id { get; set; }
        public string? gatunek { get; set; }

        public string? wystepowanie { get; set; }
        public bool? czy_zagroznoy { get; set; }
        public string? obraz { get; set; }
    }
}
