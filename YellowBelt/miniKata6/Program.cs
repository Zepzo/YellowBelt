namespace miniKata6;

class Program
{
    static void Main(string[] args)
    {
        string[] enemies = ["Goblin", "Orc", "Troll"];
        //string[] invetory = ["Sword", "Shield", "Potion", ""];

        var inventory = new List<string>();

        inventory.Add("Sword");
        inventory.Add("Shield");
        inventory.Add("Potion");
        
        for (int i = 0; i < enemies.Length; i++)
        {
            Console.WriteLine(enemies[i]);
        }

        Console.WriteLine();

        foreach (string i in inventory)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();
        
        inventory.Add("Helmet");

        foreach (string i in inventory)
        {
            Console.WriteLine(i);
        }
    }
}