using ChainOfResponsibility.Abstraction;
using ChainOfResponsibility.Enum;

namespace ChainOfResponsibility.Implementation;

public class DebugLogger : Logger
{
    public DebugLogger() : base(LogLevel.Debug) {}

    public override void Log(string message, LogLevel level)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        base.Log(message, level);
        Console.ForegroundColor = ConsoleColor.White;
    }

    protected override void Write(string message)
    {
        Console.WriteLine($"[DEBUG] {message}");
    }
}