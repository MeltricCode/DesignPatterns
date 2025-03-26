using ChainOfResponsibility.Abstraction;
using ChainOfResponsibility.Enum;

namespace ChainOfResponsibility.Implementation;

public class InfoLogger : Logger
{
    public InfoLogger() : base(LogLevel.Info) { }

    public override void Log(string message, LogLevel level)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        base.Log(message, level);
        Console.ForegroundColor = ConsoleColor.White;
    }

    protected override void Write(string message)
    {
        Console.WriteLine($"[INFO] {message}");
    }
}