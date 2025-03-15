namespace Prototype;

public abstract class Person
{
    protected Person(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    
    /// <summary>
    /// Make a copy of current instance
    /// </summary>
    /// <returns></returns>
    public abstract Person Clone();
}