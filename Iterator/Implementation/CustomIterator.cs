using Iterator.Interface;

namespace Iterator.Implementation;

public class CustomIterator : IIterator<string>
{
    private readonly CustomCollection _collection;
    private int _index = 0;
    public CustomIterator(CustomCollection collection)
    {
        _collection = collection;
    }

    public bool HasNext() => _index < _collection.GetItems().Count;

    public string Next() => _collection.GetItems()[_index++];
}