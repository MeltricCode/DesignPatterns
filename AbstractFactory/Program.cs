using AbstractFactory.Concrete;
using AbstractFactory.Interface;

// Abstract Factory Pattern:
// A creational design pattern that provides an interface for creating families of related
// or dependent objects without specifying their concrete classes.
// It allows you to produce different types of products (that are related) using a common interface,
// ensuring consistency among products that belong to the same family.
// Useful when your code needs to work with various families of products, but you don't want
// it to depend on the specific classes that create them.


Country userCountry = Country.Iran; 

IInternationalFactory factory = new InternationalFactory(userCountry);

ICapitalCity capital = factory.CreateCapital();
ILanguage language = factory.CreateLanguage();

capital.GetPopulation();
capital.ListTopAttractions();

language.Greet();

