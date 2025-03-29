namespace Iterator.Interface;

public interface IIterable<T>
{
    IIterator<T> GetIterator();
}