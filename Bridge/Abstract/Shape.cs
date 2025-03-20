using Bridge.Interface;

namespace Bridge.Abstract;

public abstract class Shape(IDrawable drawableShape)
{
    protected IDrawable Drawable = drawableShape;

    public abstract void DrawShape();
}