using System.Text.Json;
using Adapter.Interface;

namespace Adapter.Concrete;

public class JsonParser<T> : IJsonParser<T>
{
    public T ConvertToObj(string json)
    {
        return JsonSerializer.Deserialize<T>(json)!;
    }

    public string ConvertToJson(T obj)
    {
        return JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true })!;
    }
}