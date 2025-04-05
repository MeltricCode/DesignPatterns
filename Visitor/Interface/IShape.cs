namespace Visitor.Interface;

public interface IShape
{
    void Accept(IShapeVisitor visitor);
}