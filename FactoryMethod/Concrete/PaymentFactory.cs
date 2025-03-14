using FactoryMethod.Concrete.Payments;
using FactoryMethod.Enum;
using FactoryMethod.Interface;

namespace FactoryMethod.Concrete;

public class PaymentFactory 
{
    public static IPayment Create(Payment paymentMethod)
    {
        switch (paymentMethod)
        {
            case Payment.CreditCard:
                return new CreditCardPayment();
                break;
            case Payment.ApplePay:
                return new ApplePayment();
                break;
            case Payment.GooglePay:
                return new GooglePayment();
                break;
            default:
                throw new AggregateException("Invalid payment type");
        }
    }
}