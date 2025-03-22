using Decorator.Enum;

namespace Decorator.Concrete;

public class LevelBaseLogger(LogLevel minLevel) : Logger
{
    private readonly LogLevel _minLevel = minLevel;
    
    public void Log(LogLevel level, string message)
    {
        if(level >= _minLevel)
            Console.WriteLine($"Log [Level: {level}, Message: {message}]");
    }
}