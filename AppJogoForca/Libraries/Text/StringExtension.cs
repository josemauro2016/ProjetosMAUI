namespace AppJogoForca.Libraries.Text;

public static class StringExtension
{
    public static List<int> GetPositions(this string str, string value)
    {
        if (String.IsNullOrEmpty(value))        
            throw new ArgumentException("O texto não pode estar vazio", "value");
        List<int> indexes = new List<int>();
        for(int index = 0; ; index += value.Length)
        {
            index = str.IndexOf(value, index);
            if(index == -1)
                return indexes;
            indexes.Add(index);
        }
    }
}
