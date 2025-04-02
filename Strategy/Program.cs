
using Strategy.Class;
using Strategy.Enum;
using Strategy.Interface;

const decimal amount = 10000;

TaxCalculatorFactory factory = new();

TaxCalculator iranTaxCalculator = factory.CreateTaxCalculator(Countries.Iran);
TaxCalculator usaTaxCalculator = factory.CreateTaxCalculator(Countries.Usa);
TaxCalculator ukTaxCalculator = factory.CreateTaxCalculator(Countries.Uk);


Console.WriteLine($"Iran Tax: {iranTaxCalculator.GetTaxAmount(amount)}");
Console.WriteLine($"USA Tax: {usaTaxCalculator.GetTaxAmount(amount)}");
Console.WriteLine($"UK Tax: {ukTaxCalculator.GetTaxAmount(amount)}");
