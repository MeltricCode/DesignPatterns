namespace Singleton.AbstractClass;

public class SingletoneLoggerBase
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
    
    public void Log(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}