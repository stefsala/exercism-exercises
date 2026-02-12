public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string separator)
    {
        return str.Split(separator)[1];
    }
    // TODO: define the 'SubstringAfter()' extension method on the `string` type

    public static string SubstringBetween(this string str, string firstChar, string lastChar)
    {
        var index1 = str.IndexOf(firstChar) + firstChar.Length -1;
        var index2 = str.IndexOf(lastChar) - 1;
        if (index1 != -1 && index2 != -1)
            return str.Substring(index1 +1 ,index2 - index1);
        else
            return "";
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type

    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }
    // TODO: define the 'Message()' extension method on the `string` type

    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
}