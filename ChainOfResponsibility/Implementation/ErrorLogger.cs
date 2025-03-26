using ChainOfResponsibility.Abstraction;
using ChainOfResponsibility.Enum;

namespace ChainOfResponsibility.Implementation;

public class ErrorLogger : Logger
{
    public ErrorLogger() : base(LogLevel.Error){}

    public override void Log(string message, LogLevel level)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        base.Log(message, level);
        Console.ForegroundColor = ConsoleColor.White;
    }

    protected override void Write(string message)
    {
        Console.WriteLine($"[Error] {message}");
    }
}