using Decorator.Concrete;
using Decorator.Enum;

/*
The Decorator Design Pattern promotes modularity and
extensibility while adhering to the Open/Closed Principle (OCP)
by enabling dynamic behavior modifications without modifying existing code.
 */

// Base Logger
Logger logger2 = new();

logger2.Log("API has been initialized from Normal Logger");


// Featured Logger
LevelBaseLogger logger = new(LogLevel.Info);

logger.Log(LogLevel.Info, "Acknowledgment sent to the provider.");

logger.Log(LogLevel.Debug, "API has been initialized."); // This won't execute due to the minimum level set in LevelBaseLogger.

logger.Log("API has been initialized."); // This will execute due to the implementation of the log method in the Logger class.


