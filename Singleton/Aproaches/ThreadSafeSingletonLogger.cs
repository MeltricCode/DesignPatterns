using Singleton.AbstractClass;

namespace Singleton.Aproaches;

public class ThreadSafeSingletonLogger : SingletoneLoggerBase
{
    private static ThreadSafeSingletonLogger _instance;
    private static readonly object _lock = new();

    private ThreadSafeSingletonLogger() { }

    public static ThreadSafeSingletonLogger GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new ThreadSafeSingletonLogger();
                }
                
            }
        }
        
        return _instance;
    }
}