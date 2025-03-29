using Iterator.Implementation;
using Iterator.Interface;


CustomCollection collection = new CustomCollection();
collection.AddItem("Apple");
collection.AddItem("Banana");
collection.AddItem("Orange");

IIterator<string> iterator = collection.GetIterator();

while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}
