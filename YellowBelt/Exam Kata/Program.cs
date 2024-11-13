namespace Exam_Kata;

class Program
{
    static void Main(string[] args)
    {
        
    }
}

interface ICombat
{
    void Attack()
    {
        
    }

    void TakeDamage()
    {
        
    }
}

interface IInteraction
{
    void Sepak()
    {
        
    }
}

class Player: ICombat
{
    private string name;
    private int health = 100;
    private int level = 2;
    private int experience = 25;
    
    void Attack()
    {
        
    }

    void TakeDamge()
    {
        
    }
}

class Enemy: ICombat
{
    private string type = "Slime";
    private int health = 50;
    private int damage = 10;
    
    void Attack()
    {
        
    }

    void SlimeAttack()
    {
        
    }

    void TakeDamge()
    {
        
    }
}

class NPC: IInteraction
{
    private string dialouge = "Welcome to our village";
    void Speak()
    {
        Console.WriteLine($"Villager says: {dialouge}");
    }
}

class Merchant: IInteraction
{
    private string dialouge = "Take a look at my wares";
    private List<string> inventory = new (){ "Sword", "Shield", "Potion" };
    
    void Speak()
    {
        Console.WriteLine($"Merchant says {dialouge}");
    }

    void Trade()
    {
        foreach (var items in inventory)
        {
            Console.Write($"{items},");
        }
    }
}