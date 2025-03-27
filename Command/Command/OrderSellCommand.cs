using Command.Class;
using Command.Interface;

namespace Command.Command;

public class OrderSellCommand : IOrderCommand
{
    private Stock _stock;

    public OrderSellCommand(Stock stock)
    {
        _stock = stock;
    }
    public void Execute()
    {
        _stock.Sell();
    }
}