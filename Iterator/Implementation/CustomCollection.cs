using Iterator.Interface;

namespace Iterator.Implementation;

public class CustomCollection: IIterable<string>
{
    private List<string> items = new();
    
    public void AddItem(string item) => items.Add(item);
    
    public List<string> GetItems() => items;
    
    public IIterator<string> GetIterator() => new CustomIterator(this);
}