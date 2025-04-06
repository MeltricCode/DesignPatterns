using Bridge.Abstract;
using Bridge.Concrete;


// Bridge Pattern:
// A structural design pattern that decouples an abstraction from its implementation
// so that the two can vary independently.
// It separates the interface (abstraction) from the concrete implementation,
// allowing flexibility and scalability in large systems.
// Useful when you have multiple dimensions of variation that should not be tightly coupled.


Shape circle = new Circle(new RedCircle());
Shape circle2 = new Circle(new GreenCircle());

circle.DrawShape();
circle2.DrawShape();

Console.WriteLine("\nDrawing completed.");
