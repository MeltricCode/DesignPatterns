
using Proxy;
using Proxy.Implementation;

// Proxy Pattern:
// A structural design pattern that provides a surrogate or placeholder for another object to control access to it.
// It is used to add a layer of control, such as lazy loading, access control, logging, or caching.
// The proxy implements the same interface as the original object and forwards requests to it,
// optionally adding extra behavior before or after the call.


OrderServiceProxy orderProxy = new(new OrderService());

int orderId = 58;
orderProxy.ProcessOrder(orderId);