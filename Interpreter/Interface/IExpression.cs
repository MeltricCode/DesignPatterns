using Interpreter.Class;

namespace Interpreter.Interface;

public interface IExpression
{
    void Interpret(Context context);
}