using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();
        for (int i=0; i < identifier.Length; i++)
            if (identifier[i] == ' ')
                sb.Append('_');
            else if (char.IsControl(identifier[i]))
                sb.Append("CTRL");
            else if (identifier[i] == '-')
            {
                i++;
                if (i < identifier.Length)
                    sb.Append(char.ToUpper(identifier[i]));
            } else if (!(identifier[i] >= '\u03B1' && identifier[i] <= '\u03C9') && char.IsLetter(identifier[i]))
                sb.Append(identifier[i]);
        return sb.ToString();
    }
}
