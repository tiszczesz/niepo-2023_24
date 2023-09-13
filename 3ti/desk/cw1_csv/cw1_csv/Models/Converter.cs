using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw1_csv.Models
{
    public class Converter
    {
        public Converter() { }

        public static DataTable CSVFileToList(string filename) {
            List<string[]> lines = new List<string[]>();
            var fromFile = File.ReadAllLines(filename).ToList();
            foreach (var line in fromFile) {
                lines.Add(line.Split(';'));
            }
            DataTable dt = new DataTable();
            foreach (var column in lines[0]) {
                dt.Columns.Add(column);
            }

            for (int i = 1; i < lines.Count; i++) {
                dt.Rows.Add(lines[i]);
            }
            return dt;
        }
    }
}
