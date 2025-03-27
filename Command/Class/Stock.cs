namespace Command.Class;

public class Stock
{
    public int Count { get; set; }
    public string Name { get; set; }

    public void Sell()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"'{Name}' is selling, '{Count}' items");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void Buy()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"'{Name}' is buying, '{Count}' items");
        Console.ForegroundColor = ConsoleColor.White;
    }
}