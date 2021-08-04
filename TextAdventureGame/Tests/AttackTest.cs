using System;
namespace TextAdventureGame
{
    public static class AttackTest
    {
        public static void Attack(int strength)
        {
            for (int i = 0; i < 100; i++)
            {
                Random rdn = new Random();
                var attack = rdn.Next(1, strength + 1);

                Console.WriteLine(attack);
                i++;
            }
        }
    }
}
