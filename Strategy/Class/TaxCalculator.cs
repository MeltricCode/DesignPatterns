using Strategy.Interface;

namespace Strategy.Class;

public class TaxCalculator
{
    private readonly ITaxStrategy _strategy;

    public TaxCalculator(ITaxStrategy strategy)
    {
        _strategy = strategy; 
    }

    public decimal GetTaxAmount(decimal price)
    {
        decimal value = _strategy.CalculateTax(price);
        return value;
    }
}