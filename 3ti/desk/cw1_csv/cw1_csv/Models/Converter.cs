using System.Data;

namespace cw1_csv.Models; 

public class Converter {
    public static DataTable? CSVFileToList(string filename) {
        var lines = new List<string[]>();
        var fromFile = File.ReadAllLines(filename).ToList();
        if (!IsCorrectCSV(fromFile)) return null;
        foreach (var line in fromFile) 
            lines.Add(line.Split(';'));
        var dt = new DataTable();
        if (lines.Count > 0) {
            foreach (var column in lines[0]) 
                dt.Columns.Add(column);

            for (int i = 1; i < lines.Count; i++)
                dt.Rows.Add(lines[i]);
            return dt;
        }
        return null;
    }

    public static bool IsCorrectCSV(List<string> linesList) {
        if (linesList.Count > 0) {
            int times = linesList[0].Count(c => c == ';');
            foreach (var elem in linesList) {
                if (times != elem.Count(c => c == ';')) return false;
            }

            return true;

        }
        return false; 
    }
}