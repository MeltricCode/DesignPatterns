using FactoryMethod.Interface;

namespace FactoryMethod.Concrete.Payments;

public class ApplePayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"You are paying {amount.ToString("C")} with your Apple Pay");
    }
}