namespace Kata10;

class Program
{
    static void Main(string[] args)
    {
        var player = new Player();
        var enemy = new Enemy();
        var npc = new NPC();
        var merchant = new Merchant();
        
        player.TakeDamage();
        enemy.TakeDamage();
        npc.Speak();
        merchant.Speak();
    }
}

interface IEntey
{
    void Speak();
    void TakeDamage();
}

class Player: IEntey
{
    public void Speak()
    {
        
    }

    public void TakeDamage()
    {
        Console.WriteLine("Player attacks Goblin and deals 20 damage");
    }
}

class Enemy : IEntey
{
    public void Speak()
    {
        
    }

    public void TakeDamage()
    {
        Console.WriteLine("Goblin takes 20 damage. Remaining health: 30");
    }
}

class NPC : IEntey
{
    public void Speak()
    {
        Console.WriteLine("Welcome to the village!");
    }

    public void TakeDamage()
    {
        
    }
}

class Merchant : IEntey
{
    public void Speak()
    {
        Console.WriteLine("Im ready to trade");
    }

    public void TakeDamage()
    {
        
    }
}