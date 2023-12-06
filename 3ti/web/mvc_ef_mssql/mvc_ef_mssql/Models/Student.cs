using System.ComponentModel.DataAnnotations;

namespace mvc_ef_mssql.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Podaj imię")]
        [Display(Name = "Imię")]
        [MinLength(2,ErrorMessage = "Za krótkie")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Podaj nazwisko")]
        [Display(Name = "Nazwisko")]
        [MinLength(2, ErrorMessage = "Za krótkie")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "podaj wiek")]
        [Range(1,150,ErrorMessage = "wiek z przedziału (1,150)")]
        public int? Age { get; set; }
    }
}