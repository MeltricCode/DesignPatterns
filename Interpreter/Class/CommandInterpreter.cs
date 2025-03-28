using Interpreter.Implementation;
using Interpreter.Interface;

namespace Interpreter.Class;

public class CommandInterpreter
{
    public List<IExpression> Parse(string command)
    {
        var expressions = new List<IExpression>();
        
        var commands = command.Split(',');

        foreach (string cmd in commands)
        {
            if (cmd.Trim().Equals("TURN ON"))
            {
                expressions.Add(new LightOnExpression());
            }
            else if (cmd.Trim().Equals("TURN OFF"))
            {
                expressions.Add(new LightOffExpression());
            }
        }
        
        return expressions;
    }
}