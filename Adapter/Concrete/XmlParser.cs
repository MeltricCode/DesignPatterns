using System.Xml.Serialization;
using Adapter.Interface;

namespace Adapter.Concrete;

public class XmlParser<T> : IXmlParser<T>
{
    private readonly XmlSerializer _serializer;
    
    public XmlParser()
    {
        _serializer = new XmlSerializer(typeof(T), new XmlRootAttribute(typeof(T).Name.ToLower()));
    }
    public T ConvertToObj(string xml)
    {
        using TextReader reader = new StringReader(xml);
        return (T)_serializer.Deserialize(reader)!;
    }

    public string ConvertToXml(T obj)
    {
        using StringWriter writer = new();
        
        _serializer.Serialize(writer, obj);
        
        return writer.ToString();
    }
}