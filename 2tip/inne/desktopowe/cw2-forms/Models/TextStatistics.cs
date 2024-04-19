namespace cw2_forms.Models;

public class TextStatistics
{
    private List<string> _lines;

    public TextStatistics(string[] lines)   
    {
        _lines = lines.ToList();
    }

    public int GetLines()
    {
        return _lines.Count;
    }

    public int GetChars()
    {
        return _lines.Sum(line => line.Length);
    }

    public int GetAlphaNum()
    {
        int total = 0;
        foreach (var line in _lines)
        {
            foreach (char c in line)
            {
                if(Char.IsLetter(c)) total++;
            }
        }
        return total;
    }
}