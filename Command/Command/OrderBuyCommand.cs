using Command.Class;
using Command.Interface;

namespace Command.Command;

public class OrderBuyCommand : IOrderCommand
{
    private Stock _stock;

    public OrderBuyCommand(Stock stock)
    {
        _stock = stock;
    }
    public void Execute()
    {
        _stock.Buy();
    }
}