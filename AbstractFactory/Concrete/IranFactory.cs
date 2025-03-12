using AbstractFactory.Interface;

namespace AbstractFactory.Concrete;

public class IranFactory : IInternationalFactory
{
    public ILanguage CreateLanguage()
    {
        return new Persian();
    }

    public ICapitalCity CreateCapital()
    {
        return new Tehran();

    }
}