using Strategy.Interface;

namespace Strategy.Implementation;

public class IranTaxStrategy : ITaxStrategy
{
    public decimal CalculateTax(decimal amount)
    {
        return amount * 0.09m;
    }
}