using Flyweight.Interface;

namespace Flyweight.Implementation;

public class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine($"Drawing Square, ClassId:{this.GetHashCode()}");
    }
}