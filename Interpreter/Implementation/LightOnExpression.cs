using Interpreter.Class;
using Interpreter.Interface;

namespace Interpreter.Implementation;

public class LightOnExpression : IExpression
{
    public void Interpret(Context context)
    {
        context.IsLightOn = true;
        Console.WriteLine("Light turned on");
    }
}