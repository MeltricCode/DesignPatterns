using ChainOfResponsibility.Enum;

namespace ChainOfResponsibility.Abstraction;

public abstract class Logger
{
    public Logger(LogLevel level)
    {
        this.level = level;
    }
    protected LogLevel level;
    protected Logger next;

    public void SetNext(Logger next)
    {
        this.next = next;
    }
    public virtual void Log(string message, LogLevel level)
    {
        if (level <= this.level)
        {
            Console.WriteLine($"[{GetType().Name}]: {message}");
        }
        
        next?.Log(message, level);
    }
    
    protected abstract void Write(string message);

}