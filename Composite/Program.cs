

using Composite.Implement;
using Composite.Interfaces;

// Composite Pattern:
// A structural design pattern used to treat individual objects and compositions of objects uniformly.
// It allows you to build tree-like structures of objects where both leaf and composite nodes
// implement the same interface.
// Useful when working with hierarchies like GUI components, file systems, or organizational charts.


IFolder serials = new Folder("250 Gb", "serials");
IFolder subFolder1 = new Folder("125 Gb", "peaky blinders all seasons");
IFolder subFolder2  = new Folder("125 Gb", "breaking bad all seasons");

serials.AddFolder(subFolder1);
serials.AddFolder(subFolder2);

Console.WriteLine("SubFolders are:");
Console.WriteLine(string.Join("", serials.SubFolders.Select(f=> $"Name: {f.Name}, Size: {f.Size}\n" )));

