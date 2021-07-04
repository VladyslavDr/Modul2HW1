using System;

public class Starter
{
    public static void Run()
    {
        var random = new Random();
        Result result = null;

        for (var item = 0; item < 100; item++)
        {
            switch (random.Next(1, 4))
            {
                case 1:
                    result = Actions.Method1();
                    break;
                case 2:
                    result = Actions.Method2();
                    break;
                case 3:
                    result = Actions.Method3();
                    break;
                default:
                    break;
            }

            if (result.Status == false)
            {
                Logger.GetLogger().Write(LogType.Error, "Action failed by a reason:");
            }
        }

        Logger.GetLogger().WriteAllLogToFile();
    }
}