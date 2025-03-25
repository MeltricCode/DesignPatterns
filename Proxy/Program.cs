
using Proxy;
using Proxy.Implementation;

/*
The Proxy Design Pattern acts as an intermediary (or "middle class")
between the client and the real object (the original class).
It works exactly like the real object but allows you to control,
modify, or enhance the behavior before or after calling the actual implementation.
*/

OrderServiceProxy orderProxy = new(new OrderService());

int orderId = 58;
orderProxy.ProcessOrder(orderId);