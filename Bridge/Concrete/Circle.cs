using Bridge.Abstract;
using Bridge.Interface;

namespace Bridge.Concrete;

public class Circle(IDrawable drawable) : Shape(drawable)
{
    public override void DrawShape()
    {
        Drawable.Draw();
    }
}