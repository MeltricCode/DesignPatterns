using Adapter.Concrete;
using Adapter.Interface;

namespace Adapter.Concrete;

public class XmlToJsonAdapter<T> : IJsonParser<T>
{
    public T ConvertToObj(string data)
    {
        IXmlParser<T> xmlParser = new XmlParser<T>();
        return xmlParser.ConvertToObj(data);
    }

    public string ConvertToJson(T obj)
    {
        IJsonParser<T> jsonParser = new JsonParser<T>();
        return jsonParser.ConvertToJson(obj);
    }
}