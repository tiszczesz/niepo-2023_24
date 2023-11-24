using System.ComponentModel.DataAnnotations;

namespace mvc_ef_mssql.Models
{
    public class MyStudent
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
    }
}