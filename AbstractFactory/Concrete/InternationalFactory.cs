using AbstractFactory.Interface;

namespace AbstractFactory.Concrete;

public class InternationalFactory : IInternationalFactory
{
    private Country _country;
    public InternationalFactory(Country country)
    {
        _country = country;
    }
    public ILanguage CreateLanguage()
    {
        switch (_country)
        {
            case Country.Iran:
                return new Persian();
            case Country.England:
                return new English();
            case Country.Spain:
                return new Spanish();
            default:
                throw new ArgumentException();
        }
    }

    public ICapitalCity CreateCapital()
    {
        switch (_country)
        {
            case Country.Iran:
                return new Tehran();
            case Country.England:
                return new London();
            case Country.Spain:
                return new Spain();
            default:
                throw new ArgumentException();
        }
    }
}