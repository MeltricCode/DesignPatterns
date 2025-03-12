using AbstractFactory.Interface;

namespace AbstractFactory.Concrete;

public class English : ILanguage
{
    public void Greet()
    {
        Console.WriteLine("Hello!");
    }
}