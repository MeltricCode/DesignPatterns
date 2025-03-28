using Interpreter.Class;
using Interpreter.Interface;

namespace Interpreter.Implementation;

public class LightOffExpression : IExpression
{
    public void Interpret(Context context)
    {
        context.IsLightOn = false;
        Console.WriteLine("Light turned off");
    }
}