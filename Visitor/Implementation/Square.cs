using Visitor.Interface;

namespace Visitor.Implementation;

public class Square : IShape
{
    public Square(double side)
    {
        Side = side;
    }
    public double Side { get; set; }
    
    public void Accept(IShapeVisitor visitor)
    {
        visitor.Visit(this);
    }
}