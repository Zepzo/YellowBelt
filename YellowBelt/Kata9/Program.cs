namespace Kata9;

class Program
{
    static void Main(string[] args)
    {
        var player = new Player();
        var enemy = new Enemy();
        var npc = new NPC();
        var merchant = new Merchant();
        
        player.Attack("Goblin");
        enemy.TakeDamage(20);
        npc.Speak();
        merchant.Trade();

    }
}

class Player
{
    public string Name = "Zätha";
    public int Health = 100;
    public int Level = 1;

    public void Attack(string enemy)
    {
        Console.WriteLine($"{Name} attacks {enemy}");
    }
}

class Enemy
{
    public string Type = "Goblin";
    public int Health = 50;
    public int Damage = 10;

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Type} has {Health} left");
    }
}

class NPC
{
    public string Name = "Cool Guy";
    public string Dialogue = "Im Cool Guy!";

    public void Speak()
    {
        Console.WriteLine(Dialogue);
    }
}

class Merchant
{
    public string Name = "Bird Person";
    
    List<string> inventory = new();

    private void AddToInventory()
    {
        inventory.Add("Stone");
        inventory.Add("Wood");
        inventory.Add("Glass");
    }

    public void Trade()
    {
        AddToInventory();

        Console.WriteLine("Merchants's inventory");
        foreach (var items in inventory)
        {
            Console.WriteLine(items);
        }
    }

}