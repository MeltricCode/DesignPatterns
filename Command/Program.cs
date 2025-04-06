
using Command;
using Command.Class;
using Command.Command;

// Command Pattern:
// A behavioral design pattern that turns a request into a stand-alone object,
// encapsulating all the details of the request. This allows for parameterization of clients
// with different requests, queuing of requests, and logging of the requests.
// It also provides support for undo/redo operations.
// Useful when you want to decouple the sender of a request from the object that executes it.


OrderSellCommand sell = new(new Stock(){Count = 5, Name = "Energy Drink"});
OrderBuyCommand buy = new(new Stock(){Count = 90, Name = "Fanta"});
OrderBroker broker = new();

broker.AddOrder(sell);
broker.AddOrder(buy);

broker.PlaceOrders();
