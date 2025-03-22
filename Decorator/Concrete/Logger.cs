using Decorator.Interface;

namespace Decorator.Concrete;

public class Logger : ILogger
{
    public virtual void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}