using Strategy.Interface;

namespace Strategy.Implementation;

public class UsaTaxStrategy : ITaxStrategy
{
    public decimal CalculateTax(decimal amount)
    {
        return amount * 0.07m;
    }
}