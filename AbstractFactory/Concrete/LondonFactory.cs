using AbstractFactory.Interface;

namespace AbstractFactory.Concrete;

public class LondonFactory : IInternationalFactory
{
    public ILanguage CreateLanguage()
    {
        return new English();
    }

    public ICapitalCity CreateCapital()
    {
        return new London();

    }
}