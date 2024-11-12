namespace Kata6;

class Program
{
    static void Main(string[] args)
    {
        string[] enemies = ["Goblin", "Orc", "Troll", "Skeleton", "Dragon"];

        Console.WriteLine($"Enemies:");
        for (int i = 0; i < enemies.Length; i++)
        {
            
            Console.WriteLine($"{enemies[i]}");
        }
        
        Console.WriteLine();
        
        var invetory = new List<string>();
        invetory.Add("Sword");
        invetory.Add("Shield");
        invetory.Add("Potion");

        Console.WriteLine($"Player invetory");
        foreach (var i in invetory)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine();
        
        invetory.Add("Helmet");
        invetory.Add("Armor");
        invetory.Remove("Potion");

        Console.WriteLine($"Uppdated invetory");
        foreach (var i in invetory)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine();
        
        Console.WriteLine($"Total item in inventory: {invetory.Count}");
    }
}