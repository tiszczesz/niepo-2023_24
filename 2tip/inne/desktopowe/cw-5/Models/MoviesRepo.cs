using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace cw_5.Models
{
    internal class MoviesRepo
    {
        public List<Movie> Movies { get; set; }

        public List<Movie>? LoadFromFile(string filename)
        {
            string lines = File.ReadAllText(filename);
            return JsonSerializer.Deserialize<List<Movie>>(lines);
        }

        public MoviesRepo(string filename)
        {
            Movies = LoadFromFile(filename) ?? new List<Movie>();
        }
    }
}
