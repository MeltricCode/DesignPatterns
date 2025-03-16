using Singleton.AbstractClass;

namespace Singleton.Aproaches;

public class LazySingletonLogger : SingletoneLoggerBase
{
    private static readonly Lazy<LazySingletonLogger> _instance = 
        new(() => new LazySingletonLogger());

    private LazySingletonLogger() { }
    
    public static LazySingletonLogger GetInstance()
    {
        return _instance.Value;
    }
    
}