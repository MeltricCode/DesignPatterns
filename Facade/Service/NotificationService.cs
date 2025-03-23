namespace Facade.Service;

public class NotificationService
{
    public void SendConfirmation(string email)
    {
        Console.WriteLine($"Order confirmation sent to {email}.");
    }
}
