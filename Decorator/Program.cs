using Decorator.Concrete;
using Decorator.Enum;

/*
The Decorator Design Pattern promotes modularity and
extensibility while adhering to the Open/Closed Principle (OCP)
by enabling dynamic behavior modifications without modifying existing code.
 */

LevelBaseLogger logger = new(LogLevel.Info);


logger.Log(LogLevel.Info, "Acknowledgment sent to the provider.");

logger.Log(LogLevel.Debug, "API has been initialized."); // This won't execute due to the minimum level set in LevelBaseLogger.

logger.Log("API has been initialized."); // This will execute due to the implementation of the log method in the Logger class.
