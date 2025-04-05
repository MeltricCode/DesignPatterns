using Visitor.Implementation;
using Visitor.Interface;


// Visitor Design Pattern:
// A behavioral pattern that lets you define new operations on a set of objects
// without changing their classes. It promotes separation of concerns by
// encapsulating related behavior into visitor objects.
// Ideal when the object structure is stable but operations vary frequently.

List<IShape> shapes = new List<IShape>
{
    new Circle(15),
    new Square(12),
};


IShapeVisitor printVisitor = new PrintVisitor();

foreach (var shape in shapes)
{
    shape.Accept(printVisitor);
}