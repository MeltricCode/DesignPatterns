using Facade.Facade;


// The Facade Pattern provides a simplified interface to a complex system.
// It hides the complexity of multiple subsystems and exposes a unified API.
// This improves code maintainability, reduces dependencies, and enhances readability.
// In this example, OrderFacade simplifies the process of placing an order  
// by internally handling payment, inventory check, shipping, and notifications.

OrderFacade orderFacade = new OrderFacade();

orderFacade.PlaceOrder(
    productId: "8585",
    cardNumber: "1234-5678-9876-5432",
    amount: 500,
    address: "New York, 5th Avenue, No. 10",
    email: "customer@example.com"
);