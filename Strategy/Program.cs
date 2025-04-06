
using Strategy.Class;
using Strategy.Enum;
using Strategy.Interface;

// Strategy Pattern:
// A behavioral design pattern that defines a family of algorithms, encapsulates each one,
// and makes them interchangeable. The strategy pattern allows a client to choose the algorithm
// it needs at runtime, promoting flexibility and reusability without modifying the context code.
// It is useful when you need to vary the behavior of a class based on different conditions or requirements.


const decimal amount = 10000;

TaxCalculatorFactory factory = new();

TaxCalculator iranTaxCalculator = factory.CreateTaxCalculator(Countries.Iran);
TaxCalculator usaTaxCalculator = factory.CreateTaxCalculator(Countries.Usa);
TaxCalculator ukTaxCalculator = factory.CreateTaxCalculator(Countries.Uk);


Console.WriteLine($"Iran Tax: {iranTaxCalculator.GetTaxAmount(amount)}");
Console.WriteLine($"USA Tax: {usaTaxCalculator.GetTaxAmount(amount)}");
Console.WriteLine($"UK Tax: {ukTaxCalculator.GetTaxAmount(amount)}");
