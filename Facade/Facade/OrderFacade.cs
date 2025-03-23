using Facade.Service;

namespace Facade.Facade;

public class OrderFacade
{
    private readonly PaymentService _paymentService;
    private readonly InventoryService _inventoryService;
    private readonly ShippingService _shippingService;
    private readonly NotificationService _notificationService;

    public OrderFacade()
    {
        _paymentService = new PaymentService();
        _inventoryService = new InventoryService();
        _shippingService = new ShippingService();
        _notificationService = new NotificationService();
    }

    public void PlaceOrder(string productId, string cardNumber, decimal amount, string address, string email)
    {
        Console.WriteLine("Processing Order...");

        if (_inventoryService.CheckStock(productId))
        {
            if (_paymentService.ProcessPayment(cardNumber, amount))
            {
                _shippingService.ShipProduct(productId, address);
                _notificationService.SendConfirmation(email);
                Console.WriteLine("Order placed successfully.");
            }
            else
            {
                Console.WriteLine("Payment Failed. Order not placed.");
            }
        }
        else
        {
            Console.WriteLine("Product is out of stock.");
        }
    }
}