namespace MiniKata7;

class Program
{
    static void Main(string[] args)
    {
        var player = new Player();

        player.Name = "Zätha";
        player.Health = 100;
        player.Level = 10;
        
        var enemy = new Enemy();

        enemy.Name = "Goblin";
        enemy.Health = 50;
        enemy.Damage = 15;
        
        Console.WriteLine($"Player info: \nName: {player.Name} \nHealth: {player.Health} \nLevel: {player.Level}");
        
        Console.WriteLine();
        
        Console.WriteLine($"Enemy info: \nType: {enemy.Name} \nHealth: {enemy.Health} \nDamage: {enemy.Damage}");

    }
}

class Player
{
    public string Name;
    public int Health;
    public int Level;
}

class Enemy
{
    public string Name;
    public int Health;
    public int Damage;
}