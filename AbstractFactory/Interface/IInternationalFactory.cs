namespace AbstractFactory.Interface;

public interface IInternationalFactory
{
    ILanguage CreateLanguage();
    ICapitalCity CreateCapital();
}