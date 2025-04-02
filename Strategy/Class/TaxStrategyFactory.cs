using Strategy.Enum;
using Strategy.Implementation;
using Strategy.Interface;

namespace Strategy.Class;

public class TaxCalculatorFactory
{
    public TaxCalculator CreateTaxCalculator(Countries country)
    {
        return country switch
        {
            Countries.Iran => new TaxCalculator(new IranTaxStrategy()),
            Countries.Usa => new TaxCalculator(new UsaTaxStrategy()),
            Countries.Uk => new TaxCalculator(new UkTaxStrategy()),
            _ => throw new ArgumentException("Unknown Country")
        };
    }
}