using System;
using System.Threading;

namespace TextAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stillAlive = true;
            bool ranAway = false;

            var marine = GamePlay.StartUp();
            Console.Clear();

            marine = GamePlay.GearUpArmor(marine);
            Console.Clear();

            marine = GamePlay.GearUpWeapon(marine);
            Console.Clear();

            //test Marine object
            //MarineStatsTest.MarineStats(marine);

            //Attack Test
            //AttackTest.Attack(marine.AttackStrength);

            do
            {
                do
                {
                    var random = GamePlay.RandomAlien();

                    Alien alien = GamePlay.GenerateAlien(random);

                    stillAlive = Combat.Battle(marine, alien);

                    if(!stillAlive)
                    {
                        break;
                    }

                } while (marine.AliensToKill > 0);

            } while (!stillAlive);

            //methods for survival or death

            Environment.Exit(0);
        }
    }
}
