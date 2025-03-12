using AbstractFactory.Interface;

namespace AbstractFactory.Concrete;

public class London : ICapitalCity
{
    public void GetPopulation()
    {
        Console.WriteLine("Population: 1500");
    }

    public void ListTopAttractions()
    {
        Console.WriteLine("Attractions: Big Bang clock, churches, Queen Palace");
    }
}