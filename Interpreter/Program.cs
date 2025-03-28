
using Interpreter.Class;
using Interpreter.Implementation;
using Interpreter.Interface;

// The Interpreter pattern processes a given language by defining a grammar and evaluating expressions based on it.  
// It is useful for parsing, interpreting, and executing structured text or expressions dynamically.  

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
    