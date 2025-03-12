using AbstractFactory.Concrete;
using AbstractFactory.Interface;

Country userCountry = Country.Iran; 

IInternationalFactory factory = new InternationalFactory(userCountry);

ICapitalCity capital = factory.CreateCapital();
ILanguage language = factory.CreateLanguage();

capital.GetPopulation();
capital.ListTopAttractions();

language.Greet();

