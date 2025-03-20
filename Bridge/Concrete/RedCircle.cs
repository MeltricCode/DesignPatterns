using Bridge.Interface;

namespace Bridge.Concrete;

public class RedCircle : IDrawable
{
    public void Draw()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Drawing red circle");
        Console.ForegroundColor = ConsoleColor.White;
        ;
    }
}