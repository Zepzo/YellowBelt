namespace Kata8;

class Program
{
    static void Main(string[] args)
    {
        var player = new Player();
        
        player.GainExperience(50);
        player.GainExperience(60);
        player.GainExperience(50);
        player.GainExperience(60);
    }
}

class Player
{
    private int health;
    private int level;
    private int experience;

    public int Health
    {
        get { return health;}
        set {}
    }

    public int Level
    {
        get { return level; }
        set { health = Math.Abs(value); }
    }

    public int Experience
    {
        get { return experience; }
        set { experience = Math.Abs(value); }
    }

    private void LevelUp()
    {
            level++;
            experience = 0;
            Console.WriteLine($"Congratulations! You leveled up to Level {level}");
    }

    public void GainExperience(int exp)
    {
        Console.WriteLine($"Player gain {exp} experience points");
        experience += exp;
        if (experience >= 100)
        {
            LevelUp();
        }
    }
}