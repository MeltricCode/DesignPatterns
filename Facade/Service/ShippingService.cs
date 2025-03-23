namespace Facade.Service;

public class ShippingService
{
    public void ShipProduct(string productId, string address)
    {
        Console.WriteLine($"Product {productId} has been shipped to {address}.");
    }
}
