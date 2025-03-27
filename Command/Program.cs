
using Command;
using Command.Class;
using Command.Command;

OrderSellCommand sell = new(new Stock(){Count = 5, Name = "Energy Drink"});
OrderBuyCommand buy = new(new Stock(){Count = 90, Name = "Fanta"});
OrderBroker broker = new();

broker.AddOrder(sell);
broker.AddOrder(buy);

broker.PlaceOrders();
