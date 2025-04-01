namespace Memento.Class;

public class TextEditor
{
    private string _text = "";
    private readonly TextHistory _textHistory = new();
    public void AppendText(string text)
    {
        _text += text;
    }
    public string GetText() => _text;
    
    public void Save()
    {
        _textHistory.SaveState(new TextMemento(_text));
    }  

    public void Undo()
    {
        _text = _textHistory.Undo().State;
    }
}