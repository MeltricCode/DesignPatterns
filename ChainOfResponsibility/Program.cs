using ChainOfResponsibility;
using ChainOfResponsibility.Abstraction;
using ChainOfResponsibility.Enum;
using ChainOfResponsibility.Implementation;

// Chain of Responsibility (COR) Pattern:
// Passes a request through a chain of handlers, each deciding to process or forward it.  
// Promotes loose coupling and flexible request handling.  
// Common in logging, authentication, and middleware.  


// Logs will be processed in the order: Info → Debug → Error
Logger logger = LoggerFactory.CreateLogger(new List<Logger>
{
    new InfoLogger(),
    new DebugLogger(),
    new ErrorLogger(),
});

logger.Log("Test Logger", LogLevel.Info);


