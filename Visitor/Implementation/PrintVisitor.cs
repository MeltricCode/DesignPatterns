using Visitor.Interface;

namespace Visitor.Implementation;

public class PrintVisitor : IShapeVisitor
{
    public void Visit(IShape shape)
    {
        switch (shape)
        {
            case Circle c : 
                Console.WriteLine($"Circle with radius: {c.Radius}");
                break;
            case Square s:
                Console.WriteLine($"Square with side: {s.Side}");
                break;
            default:
                Console.WriteLine("Unknown shape.");
                break;
            
        }
    }
}