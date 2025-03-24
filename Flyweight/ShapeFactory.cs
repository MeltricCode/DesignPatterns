using Flyweight.Enum;
using Flyweight.Implementation;
using Flyweight.Interface;

namespace Flyweight;

public class ShapeFactory
{
    private static Dictionary<ShapeEnum, IShape> _shapeFactory = new();

    public static IShape GetShape(ShapeEnum shape)
    {
        if(_shapeFactory.Any(s=>s.Key == shape))
            return _shapeFactory.FirstOrDefault(s=>s.Key == shape).Value;

        switch (shape)
        {
            case ShapeEnum.Circle:
                IShape circle = new Circle();
                _shapeFactory.Add(shape, circle);
                return circle;
            case ShapeEnum.Rectangle:
                IShape rectangle = new Rectangle();
                _shapeFactory.Add(shape, rectangle);
                return rectangle;
            case ShapeEnum.Square:
                IShape square = new Square();
                _shapeFactory.Add(shape, square);
                return square;
            default:
                throw new ArgumentException("Unknown shape");
        }
    }
}