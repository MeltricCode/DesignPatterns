using AbstractFactory.Interface;

namespace AbstractFactory.Concrete;

public class Spanish : ILanguage
{
    public void Greet()
    {
        Console.WriteLine("Holla!");
    }
}