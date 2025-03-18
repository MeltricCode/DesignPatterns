namespace Adapter.Interface;

public interface IXmlParser<T>
{
    T ConvertToObj(string xml);

    string ConvertToXml(T obj);
}