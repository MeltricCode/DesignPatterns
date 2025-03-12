using AbstractFactory.Interface;

namespace AbstractFactory.Concrete;

public class Persian : ILanguage
{
    public void Greet()
    {
        Console.WriteLine("Salam!");
    }
}