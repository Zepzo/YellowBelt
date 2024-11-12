namespace Kata7;

class Program
{
    static void Main()
    {
        var player = new Player();
        var enemy = new Enemy();

        player.Attack(20);
        enemy.TakeDamage(20);
        player.GainExperience(20);

    }
}

class Player
{
    private string Name = "Zätha";
    private int Health = 30;
    private int Level = 5;
    private int Experience = 50;

    private Enemy enemy = new();

    public void Attack(int damage)
    {
        Console.WriteLine($"Player {Name} attacks the {enemy.Name} and deal {damage} damage.");
    }

    public void GainExperience(int exp)
    {
        Console.WriteLine($"Player {Name} gains {exp} experience points.");
    }
}

class Enemy
{
    public string Name = "Orc";
    private int Health = 20;
    private int Damage = 15;

    public void TakeDamage(int damage)
    {
        Console.WriteLine($"{Name} took {damage} damage.");
    }
}