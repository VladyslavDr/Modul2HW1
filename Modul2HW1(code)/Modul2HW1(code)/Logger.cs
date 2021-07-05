using System;
using System.Text;
using System.IO;

public class Logger
{
    private static Logger _logger = new Logger();

    private string _log = string.Empty;
    private StringBuilder _logs = new StringBuilder();

    private Logger()
    {
    }

    public static Logger GetLogger
    {
        get => _logger;
    }

    public void Write(LogType type, string messege)
    {
        _log = $"{DateTime.UtcNow} : {type.ToString()} : {messege}";

        _logs.AppendLine(_log);

        Console.WriteLine(_log);
    }

    public void WriteAllLogToFile()
    {
        File.WriteAllText("log.txt", _logs.ToString());
    }
}