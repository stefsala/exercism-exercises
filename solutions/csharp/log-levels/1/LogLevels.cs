static class LogLine
{
    public static string Message(string logLine)
    {
        int index_cut = logLine.IndexOf(':');
        return logLine.Substring(index_cut + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int index_cut = logLine.IndexOf(':');
        return logLine.Substring(0,index_cut).Trim( new Char[] {' ', '[', ']'}).ToLower();
    }

    public static string Reformat(string logLine)
    {
        int index_cut = logLine.IndexOf(':');
        return logLine.Substring(index_cut + 1).Trim() + " (" + logLine.Substring(0,index_cut).Trim( new Char[] {' ', '[', ']'}).ToLower() + ')';
    }
}
