namespace cw6;

public class Film
{

    public string? Title { get; set; }
    public decimal Price { get; set; }

    public string ToLine(){
        return Title+';'+Price.ToString()+Environment.NewLine;
    }

}
