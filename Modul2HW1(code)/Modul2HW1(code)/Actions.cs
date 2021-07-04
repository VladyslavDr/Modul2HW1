using System;

public class Actions
{
    private static Logger _x = Logger.GetLogger();

    public static Result Method1()
    {
        _x.Write(LogType.Info, "Start method:");
        return new Result(true);
    }

    public static Result Method2()
    {
        _x.Write(LogType.Warning, "Skipped logic in method:");
        return new Result(true);
    }

    public static Result Method3()
    {
        _x.Write(LogType.Error, "I broke a logic: ");
        return new Result(true, "что-то не так");
    }
}