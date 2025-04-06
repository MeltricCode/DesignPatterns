using Iterator.Implementation;
using Iterator.Interface;

// Iterator Pattern:
// A behavioral design pattern that provides a way to access the elements of a collection
// sequentially without exposing its underlying representation.
// It allows you to traverse a collection (like a list or set) without needing to know its internal structure,
// promoting loose coupling and greater flexibility in iterating over different types of collections.


CustomCollection collection = new CustomCollection();
collection.AddItem("Apple");
collection.AddItem("Banana");
collection.AddItem("Orange");

IIterator<string> iterator = collection.GetIterator();

while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}
