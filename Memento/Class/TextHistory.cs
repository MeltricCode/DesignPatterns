namespace Memento.Class;

public class TextHistory
{
    private Stack<TextMemento> _history = new();
    
    public void SaveState(TextMemento memento) => _history.Push(memento);
    
    public TextMemento Undo()
    {
        if (_history.Count <= 1)
            return new TextMemento("");
                
        _history.Pop();
        return _history.Peek();
    }
}