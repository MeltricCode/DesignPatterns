using Flyweight.Interface;

namespace Flyweight.Implementation;

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine($"Drawing circle, ClassId:{this.GetHashCode()}");
    }
}