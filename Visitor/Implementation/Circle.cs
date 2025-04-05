using Visitor.Interface;

namespace Visitor.Implementation;

public class Circle : IShape
{
    public Circle(double radius)
    {
        Radius = radius;
    }
    public double Radius { get; set; }
    
    public void Accept(IShapeVisitor visitor)
    {
        visitor.Visit(this);
    }
}