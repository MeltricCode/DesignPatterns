using FactoryMethod.Concrete;
using FactoryMethod.Enum;
using FactoryMethod.Interface;

// Factory Method Pattern:
// A creational design pattern that defines an interface for creating objects,
// but allows subclasses to alter the type of objects that will be created.
// It delegates the object creation to a method in a subclass, enabling flexibility in
// instantiating different types of objects without altering the client code.
// Useful when the exact type of the object cannot be determined until runtime.


IPayment payment = PaymentFactory.Create(Payment.GooglePay);

payment.Pay(2000.0);