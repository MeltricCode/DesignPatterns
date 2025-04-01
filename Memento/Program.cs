using Memento.Class;

// Memento Pattern: Captures and restores an object's state without exposing its details.
// - Memento: Stores the state.  
// - Originator: Creates and restores mementos.  
// - Caretaker: Manages saved states (undo/redo).  
// Used for undo functionality in text editors, games, etc.


TextEditor editor = new();
TextHistory history = new();

editor.AppendText("Hello");
editor.Save();

editor.AppendText(" Memento!");
editor.Save();


Console.WriteLine("Current Text: " + editor.GetText());

editor.Undo();
Console.WriteLine("First Undo: " + editor.GetText());

editor.Undo();
Console.WriteLine("Second Undo: " + editor.GetText());