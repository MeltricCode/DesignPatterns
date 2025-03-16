using Singleton.AbstractClass;

namespace Singleton.Aproaches;

public class CLassicSingletonLogger : SingletoneLoggerBase
{
    private static CLassicSingletonLogger _instance;
    
    private CLassicSingletonLogger() { }
    
    public static CLassicSingletonLogger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new CLassicSingletonLogger();
        }
        
        return _instance;
    }
}