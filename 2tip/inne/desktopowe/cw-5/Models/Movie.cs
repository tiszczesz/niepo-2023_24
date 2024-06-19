using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_5.Models
{
    public class Movie
    {
       
        public int Id { get; set; }

        [DisplayName("Tytuł")]
        public string Title { get; set; }

        [DisplayName("Reżyser")]
        public string Director { get; set; }

        [DisplayName("Data produkcji")]
        public string Date { get; set; }

        [DisplayName("Długość filmu")]
        public int Length { get; set; }
    }
}
