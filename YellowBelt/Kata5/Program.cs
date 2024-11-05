namespace MiniKata5;

class Program
{
    static void Main(string[] args)
    {
        AttackEnemy("Goblin", 20);
        HealPlayer("Zätha", 15);
        
        void AttackEnemy(string enemyName, int damage)
        {
            Console.WriteLine($"Attacked {enemyName} and dealt {damage} damage!");
        }
        
        void HealPlayer(string playerName, int healAmount)
        {
            Console.WriteLine($"Player {playerName} healed {healAmount} health points");
        }
    }

}