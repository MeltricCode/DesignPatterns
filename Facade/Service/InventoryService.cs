namespace Facade.Service;

public class InventoryService
{
    public bool CheckStock(string productId)
    {
        Console.WriteLine($"Stock checked for product {productId}.");
        return true; // Assume product is in stock
    }
}
