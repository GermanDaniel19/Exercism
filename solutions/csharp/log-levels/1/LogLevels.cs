static class LogLine
{
    public static string Message(string logLine)
    {
        string logLineTrim = logLine.Trim();
        int first = logLineTrim.IndexOf(':');
        int length = logLineTrim.Length - (first+1);
        string msn = logLineTrim.Substring(first+1,length);
        return msn.Trim();
    }

    public static string LogLevel(string logLine)
    {
        string logLineTrim = logLine.Trim();
        int start = logLineTrim.IndexOf('[')+1;
        int end = logLineTrim.IndexOf(']');
        string level = logLineTrim.Substring(start , end - start);

        return level.ToLower();
        
    }

    public static string Reformat(string logLine)
    {
        string msg = Message(logLine);
        string lvl = LogLevel(logLine);
        string message = $"{msg} ({lvl})";
        return message;
    }
}
