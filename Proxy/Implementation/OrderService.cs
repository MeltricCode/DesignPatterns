using Proxy.Interface;

namespace Proxy.Implementation;

public class OrderService : IOrderService
{
    public void ProcessOrder(int orderId)
    {
        Console.WriteLine($"Processing order {orderId}");
    }
}