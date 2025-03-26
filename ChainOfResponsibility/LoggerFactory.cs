using ChainOfResponsibility.Abstraction;
using ChainOfResponsibility.Implementation;

namespace ChainOfResponsibility;

public class LoggerFactory
{
    /// <summary>
    /// Builds a chain of loggers and returns the first one  
    /// </summary>
    /// <param name="loggers"></param>
    /// <returns>The first logger in the chain</returns>
    public static Logger CreateLogger(List<Logger> loggers)
    {
        for (int i = 0; i < loggers.Count - 1; i++)
        {
            loggers[i].SetNext(loggers[i + 1]);
        }

        return loggers.First();
    }
}