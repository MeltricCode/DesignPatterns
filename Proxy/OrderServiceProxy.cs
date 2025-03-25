using Proxy.Interface;

namespace Proxy;

public class OrderServiceProxy(IOrderService orderService)
{
    private readonly IOrderService _orderService = orderService;

    public void ProcessOrder(int orderId)
    {
        Console.WriteLine($"[LOG] Order {orderId} is about to be processed.");
        
        _orderService.ProcessOrder(orderId);

        Console.WriteLine($"[LOG] Order {orderId} has been processed.");
    }
}