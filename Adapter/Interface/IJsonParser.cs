namespace Adapter.Interface;

public interface IJsonParser<T>
{
    T ConvertToObj(string data);

    string ConvertToJson(T obj);
}
