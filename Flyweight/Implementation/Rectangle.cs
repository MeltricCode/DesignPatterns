using Flyweight.Interface;

namespace Flyweight.Implementation;

public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine($"Drawing rectangle, ClassId:{this.GetHashCode()}");
    }
}