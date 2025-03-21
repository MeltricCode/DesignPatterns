namespace Composite.Interfaces;

public interface IFolder
{
    public string Size { get; set; }
    public string Name { get; set; }
    public List<IFolder> SubFolders { get; set; }
    public void AddFolder(IFolder item);
    
    public void RemoveFolder(IFolder item);
}