using Observer.Interface;

namespace Observer.Implementation;

public class MobileApp(string name) : IObserver
{
    public readonly string Name = name;
    public void Update(string message)
    {
        Console.WriteLine($"{Name}: {message}");
    }
}