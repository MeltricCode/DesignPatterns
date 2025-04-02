using Strategy.Interface;

namespace Strategy.Implementation;

public class UkTaxStrategy : ITaxStrategy
{
    public decimal CalculateTax(decimal amount)
    {
        return amount * 0.2m;
    }
}