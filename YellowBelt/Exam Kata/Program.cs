namespace Exam_Kata;
class Program
{
    static void Main()
    {
        var game = new GameManager();

        game.GameLoop();
    }
}

interface ICombat
{
    int Health { get; }
    int Damage { get; }
    
    void GettingAttacked() {}
    void TakeDamage() {}
    void DeathCheck(){}
}

interface IInteraction
{
    void Sepak() {}
}

class GameManager
{
    public void GameLoop()
    {
        var npc = new NPC();
        var random = new Random();
        var combatManager = new CombatManger();
        var tradeManager = new TradeManager();
        
        bool runingGame = true;
        
        Console.WriteLine("What is your name?");
        string newName = Console.ReadLine();
        
        tradeManager.SetName(newName);
        combatManager.SetName(newName);

        while (runingGame)
        {
            int encounter = random.Next(1, 4);
            
            if (encounter == 1)
            {
                Console.WriteLine("You encounter an enemy:");
                runingGame = combatManager.Combat();
            }
            else if (encounter == 2)
            {
                Console.WriteLine("You encounter an NPC:");
                npc.Speak();
            }
            else if (encounter == 3)
            {
                Console.WriteLine("You encounter a Merchant");
                tradeManager.Trade();
            }
            else
            {
                Console.WriteLine("Something went wrong with the GameLoop");
            }
            
            Console.WriteLine();
            
            Thread.Sleep(5000);
        }
    }
}

class CombatManger
{
    Player player = new ();
    Enemy enemy = new ();

    public void SetName(string newName)
    {
        player.SetName(newName);
    }
    public bool Combat()
    {
        bool encounterLoop = true;
        bool isAlive = true;

        
        while (encounterLoop)
        {
            Console.WriteLine("Attack(1) or heal(2)");
            string intput = Console.ReadLine();

            if (intput == "1")
            {
                Console.WriteLine($"{player.Name} turn:");
                encounterLoop = enemy.GettingAttacked(player.Damage, player.Name);
                Console.WriteLine();
            }
            else if (intput == "2")
            {
                player.Heal();
            }
            
            if (encounterLoop == false)
            {
                continue;
            }
            
            Thread.Sleep(1000);
            
            Console.WriteLine($"{enemy.Type} turn:");
            encounterLoop = player.GettingAttacked(enemy.Damage, enemy.Type);
            Console.WriteLine();
            
            Thread.Sleep(1000);

        }

        if (player.Health <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

class TradeManager
{
    Player player = new ();
    Merchant merchant = new ();
    public void SetName(string name)
    {
        player.SetName(name);
    }
    
    public void Trade()
    {
        merchant.Speak();

        foreach (var items in merchant.merchantInvetory)
        {
            Console.WriteLine(items);
        }
        
        Console.WriteLine("Your inventory:");
        foreach (var items in player.PlayerInventtory)
        {
            Console.WriteLine(items);
        }
        
        Console.WriteLine("Do you want to buy something?(y/n)");
        string userInput = Console.ReadLine();

        if (userInput == "y" && player.Money >= 10)
        {
            Console.WriteLine("Which item do you want to purchase?");
            string userBuy = Console.ReadLine();

            merchant.merchantInvetory.Remove(userBuy);
            player.PlayerInventtory.Add(userBuy);
        }
        else if (userInput == "y" && player.Money < 10)
        {
            Console.WriteLine("insufficient funds");
        }
        else if (userInput == "n")
        {
            Console.WriteLine($"Alright have a good day {player.Name}");
        }
        else
        {
            Console.WriteLine("Something went wrong in tradeManager");
        }
        
        Console.WriteLine("Updated inventory");
        foreach (var items in player.PlayerInventtory)
        {
            Console.WriteLine(items);
        }
    }
}

class Player: ICombat
{
    private string _name = "Cool guy";
    private int _health = 100;
    private int _damage = 15;
    private int level = 2;
    private int experience = 25;
    private int _money = 10;

    public int Health
    {
        get{ return _health; }
    }

    public int Damage
    {
        get { return _damage; }
    }

    public string Name
    {
        get { return _name; }
    }

    public int Money
    {
        get { return _money; }
    }

    public void Heal()
    {
        _health += 5;
        Console.WriteLine($"{_name} healed {5}hp");
    }
    
    public void SetName(string newName)
    {
        _name = newName;
    }

    public List<string> PlayerInventtory = new() { "Cool hat" };
    
    public bool GettingAttacked(int damage, string enemyName)
    {
        Console.WriteLine($"{enemyName} attacks {Name} {Name} has {_health} hp left");
        TakeDamge(damage);
        bool isAlive = DeathChaeck();
        return isAlive;
    }

    bool DeathChaeck()
    {
        if (_health <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    void TakeDamge(int damage)
    {
        _health -= damage;
        Console.WriteLine($"{_name} took {damage} damage");
    }
    
}

class Enemy : ICombat
{
    private string _type = "Slime";
    private int _health = 50;
    private int _damage = 10;

    public int Health
    {
        get { return _health; }
    }

    public int Damage
    {
        get { return _damage; }
    }

    public string Type
    {
        get { return _type; }
    }

    public bool GettingAttacked(int damage, string playerName)
    {
        Console.WriteLine($"{playerName} attacks {_type} {_type} has {_health} hp left");
        TakeDamge(damage);
        bool isAlive = DeathChaeck();
        return isAlive;
    }

    bool DeathChaeck()
    {
        if (_health <= 0)
        {
            _health = 50;
            return false;
        }
        else
        {
            return true;
        }
    }

    void TakeDamge(int damage)
    {
        _health -= damage;
        Console.WriteLine($"{_type} takes {damage} damage");
    }
}

class NPC: IInteraction
{
    private string dialouge = "Welcome to our village";
    public void Speak()
    {
        Console.WriteLine($"Villager says: {dialouge}");
    }
}

class Merchant: IInteraction
{
    private string dialouge = "Take a look at my wares. every item is 10 money";
    public List<string> merchantInvetory = new() { "Sword", "Shield", "Potion" };

    public void Speak()
    {
        Console.WriteLine($"Merchant says {dialouge}");
    }
}