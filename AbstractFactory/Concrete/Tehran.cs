using AbstractFactory.Interface;

namespace AbstractFactory.Concrete;

public class Tehran : ICapitalCity
{
    public void GetPopulation()
    {
        Console.WriteLine("Population: 13000");
    }

    public void ListTopAttractions()
    {
        Console.WriteLine("Attractions: Milad Tower, Azadi Tower, Iran Mall");
    }
}