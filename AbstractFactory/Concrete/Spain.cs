using AbstractFactory.Interface;

namespace AbstractFactory.Concrete;

public class Spain : ICapitalCity
{
    public void GetPopulation()
    {
        Console.WriteLine("Population: 5580");
    }

    public void ListTopAttractions()
    {
        Console.WriteLine("stadum, city, ksjdkjds");
    }
}