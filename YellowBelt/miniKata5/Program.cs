namespace Kata5;

class Program
{
    static void Main(string[] args)
    {
        void AttackEnemy(int damge)
        {
            Console.WriteLine($"Player dealt {damge} damge!");
        }

        void HealPlayer(int healAmount)
        {
            Console.WriteLine($"Player healed {healAmount} health points");
        }
    }
}