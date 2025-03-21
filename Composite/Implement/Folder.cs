using Composite.Interfaces;

namespace Composite.Implement;

public class Folder : IFolder
{
    public Folder(string size, string name)
    {
        SubFolders = new();
        Size = size;
        Name = name;
    }

    public List<IFolder> SubFolders { get; set; }
    
    public string Name { get; set; }
    public string Size { get; set; }
    

    public void AddFolder(IFolder item)
    {
        SubFolders.Add(item);
    }

    public void RemoveFolder(IFolder item)
    {
        SubFolders.Remove(item);
    }
}