namespace Strategy.Interface;

public interface ITaxStrategy
{
    decimal CalculateTax(decimal amount);
}