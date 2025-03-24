
using System.Threading.Channels;
using Flyweight;
using Flyweight.Enum;
using Flyweight.Interface;

// Flyweight Pattern:  
// This pattern is used to reduce memory usage by sharing common object data.  
// Instead of creating multiple identical objects, we store shared data in a central place  
// and only create unique instances when necessary.  
// Useful for optimizing performance in applications with a large number of similar objects.  

IShape shape1 = ShapeFactory.GetShape(ShapeEnum.Circle);
IShape shape2 = ShapeFactory.GetShape(ShapeEnum.Circle);
IShape shape3 = ShapeFactory.GetShape(ShapeEnum.Rectangle);


shape1.Draw();
shape2.Draw();
shape3.Draw();

if (ReferenceEquals(shape1, shape2))
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Shape1 and Shape2 reference the same instance.");
}

