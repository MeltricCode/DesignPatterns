using FactoryMethod.Concrete;
using FactoryMethod.Enum;
using FactoryMethod.Interface;

IPayment payment = PaymentFactory.Create(Payment.GooglePay);

payment.Pay(2000.0);