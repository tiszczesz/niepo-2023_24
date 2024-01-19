using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebAppMysqlEF.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Podaj nazwę")]
        public string Name { get; set; }
        public string? Description { get; set; }

        [Precision(10,2)]
        public decimal? Price { get; set; }
        public int? Year { get; set; }
    }
}
