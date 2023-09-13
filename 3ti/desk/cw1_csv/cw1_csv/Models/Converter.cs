using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw1_csv.Models
{
    public class Converter
    {
        public Converter() { }

        public static List<string[]> CSVFileToList(string filename) {
            List<string[]> lines = new List<string[]>();
            var fromFile = File.ReadAllLines(filename).ToList();
            foreach (var line in fromFile) {
                lines.Add(line.Split(';'));
            }

            return lines;
        }
    }
}
