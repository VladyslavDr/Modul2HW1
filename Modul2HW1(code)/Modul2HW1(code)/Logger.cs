using System;

public class Logger
{
    private static Logger _logger = new Logger();

    private Logger()
    {
    }

    public static Logger GetLogger()
    {
        var x = _logger;
        return x;
    }
}