using Bridge.Interface;

namespace Bridge.Concrete;

public class GreenCircle : IDrawable
{
    public void Draw()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Drawing green circle");
        Console.ForegroundColor = ConsoleColor.White;
    }
}