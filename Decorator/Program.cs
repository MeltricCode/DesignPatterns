using Decorator.Concrete;
using Decorator.Enum;

// Decorator Pattern:
// A structural design pattern that allows behavior to be added to an object dynamically,
// without modifying its original class or using inheritance.
// It wraps the original object in a new class that adds the desired behavior.
// Useful for adding responsibilities to objects in a flexible and reusable way.


// Base Logger
Logger logger2 = new();

logger2.Log("API has been initialized from Normal Logger");


// Featured Logger
LevelBaseLogger logger = new(LogLevel.Info);

logger.Log(LogLevel.Info, "Acknowledgment sent to the provider.");

logger.Log(LogLevel.Debug, "API has been initialized."); // This won't execute due to the minimum level set in LevelBaseLogger.

logger.Log("API has been initialized."); // This will execute due to the implementation of the log method in the Logger class.


