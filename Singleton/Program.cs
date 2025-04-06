using Singleton.Aproaches;

// Singleton Pattern:
// A creational design pattern that ensures a class has only one instance
// and provides a global point of access to that instance.
// It is used when you need to control access to a shared resource, like a database connection
// or a configuration manager, and ensure that only one instance of the class is created.


TestClassicSingletoneLogger();
TestThreadSafeSingletonLogger();
TestLazySingletonLogger();
TestStaticSingletonLogger();


#region TestMethods

void TestClassicSingletoneLogger()
{
    var classic1 = CLassicSingletonLogger.GetInstance();
    var classic2 = CLassicSingletonLogger.GetInstance();

    if (classic1 == classic2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Same instance! => ClassicSingleTonLogger correctly implemented");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Multiple instance! => ClassicSingleTonLogger has not been correctly implemented");
    }
}

void TestThreadSafeSingletonLogger()
{
    var threadSafe1 = ThreadSafeSingletonLogger.GetInstance();
    var threadSafe2 = ThreadSafeSingletonLogger.GetInstance();

    if (threadSafe1 == threadSafe2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Same instance! => ThreadSafeSingletonLogger correctly implemented");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Multiple instance! => ThreadSafeSingletonLogger has not been correctly implemented");
    }
}

void TestLazySingletonLogger()
{
    var lazy1 = LazySingletonLogger.GetInstance();
    var lazy2 = LazySingletonLogger.GetInstance();

    if (lazy1 == lazy2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Same instance! => LazySingletonLogger correctly implemented");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Multiple instance! => LazySingletonLogger has not been correctly implemented");
    }
}

void TestStaticSingletonLogger()
{
    var staticLogger1 = StaticSingletonLogger.GetInstance();
    var staticLogger2 = StaticSingletonLogger.GetInstance();

    if (staticLogger1 == staticLogger2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Same instance! => StaticSingletonLogger correctly implemented");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Multiple instance! => StaticSingletonLogger has not been correctly implemented");
    }
}

#endregion
