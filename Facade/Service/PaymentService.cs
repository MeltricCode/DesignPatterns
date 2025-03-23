namespace Facade.Service;

public class PaymentService
{
    public bool ProcessPayment(string cardNumber, decimal amount)
    {
        Console.WriteLine($"Payment of {amount}$ was processed using card {cardNumber}.");
        return true;
    }
}
