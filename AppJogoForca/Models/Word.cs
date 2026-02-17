namespace AppJogoForca.Models;

public class Word
{
    public Word(String Tips, String Text)
    {
        this.Tips = Tips;
        this.Text = Text;
    }
    public String Tips { get; set; } = String.Empty;
    public String Text { get; set; } = String.Empty;
}
