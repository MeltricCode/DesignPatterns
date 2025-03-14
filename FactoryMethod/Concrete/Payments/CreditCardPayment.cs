using FactoryMethod.Interface;

namespace FactoryMethod.Concrete.Payments;

public class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"You are paying {amount.ToString("C")} with your Credit Card");
    }
}