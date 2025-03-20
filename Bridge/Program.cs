using Bridge.Abstract;
using Bridge.Concrete;

Shape circle = new Circle(new RedCircle());
Shape circle2 = new Circle(new GreenCircle());

circle.DrawShape();
circle2.DrawShape();

Console.WriteLine("\nDrawing completed.");
