

using Composite.Implement;
using Composite.Interfaces;

// The 'size' variable helps illustrate the concept; 
// however, there are more efficient ways to implement this.

IFolder serials = new Folder("250 Gb", "serials");
IFolder subFolder1 = new Folder("125 Gb", "peaky blinders all seasons");
IFolder subFolder2  = new Folder("125 Gb", "breaking bad all seasons");

serials.AddFolder(subFolder1);
serials.AddFolder(subFolder2);

Console.WriteLine("SubFolders are:");
Console.WriteLine(string.Join("", serials.SubFolders.Select(f=> $"Name: {f.Name}, Size: {f.Size}\n" )));

