using Command.Interface;

namespace Command;

public class OrderBroker
{
    private readonly List<IOrderCommand> _orders = new();

    public void AddOrder(IOrderCommand order)
    {
        _orders.Add(order);
    }

    public void PlaceOrders()
    {
        foreach (var order in _orders)
        {
            order.Execute();
        }
        _orders.Clear();
    }
}