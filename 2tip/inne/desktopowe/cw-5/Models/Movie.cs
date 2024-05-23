using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_5.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Date { get; set; }
        public int Length { get; set; }
    }
}
