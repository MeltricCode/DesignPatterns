namespace Singleton.Aproaches;

public class StaticSingletonLogger
{
    private static readonly StaticSingletonLogger _instance = new();
    
    private StaticSingletonLogger() { }

    public static StaticSingletonLogger GetInstance()
    {
        return _instance;
    }
}