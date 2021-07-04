using System;
using System.IO;

public class Logger
{
    private static Logger _logger = new Logger();
    private string _log = string.Empty;

    private Logger()
    {
    }

    public void Write(LogType type, string messege)
    {
        _log += $"{DateTime.UtcNow} : {type.ToString()} : {messege}\n";
        Console.WriteLine(_log);
    }

    public static Logger GetLogger()
    {
        var x = _logger;
        return x;
    }

    public void WriteAllLogToFile()
    {
        File.WriteAllText("log.txt", _log.ToString());
    }
}