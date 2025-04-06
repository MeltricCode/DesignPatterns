
using Interpreter.Class;
using Interpreter.Implementation;
using Interpreter.Interface;

// Interpreter Pattern:
// A behavioral design pattern that defines a grammar for interpreting sentences
// and provides an interpreter to evaluate the expressions in that grammar.
// It is useful when you need to interpret or execute sentences in a specific language,
// often in the context of parsing and interpreting structured data like expressions or queries.


Context context = new();
CommandInterpreter  interpreter = new();

string command = "TURN ON, TURN OFF, TURN ON";
List<IExpression> listOfCommands = interpreter.Parse(command);

foreach (IExpression expression in listOfCommands)
{
    expression.Interpret(context);
}

Console.WriteLine("-------------------");
Console.WriteLine($"All the Lights are {(context.IsLightOn ? "On" : "Off")}");
    