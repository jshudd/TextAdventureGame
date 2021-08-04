using System;
using System.Threading;

namespace TextAdventureGame
{
    public static class Combat
    {
        public static SpaceMarine Battle(SpaceMarine marine, Alien alien)
        {
            Console.Clear();
            Console.WriteLine($"Here comes the {alien.Name}!!");
            do
            {
                var cont = false;

                CurrentStats(marine, alien);

                do
                {
                    Console.WriteLine("Choose action:");
                    Console.WriteLine("Attack or Run");
                    Console.WriteLine();
                    var response = Console.ReadLine();

                    switch(response.ToLower())
                    {
                        case "run":
                            RunAway(marine, alien);
                            cont = true;
                            break;

                        case "attack":
                            MarineAttack(marine, alien);
                            AlienAttack(marine, alien);
                            cont = true;
                            break;

                        default:
                            Console.WriteLine("Try again.");
                            break;
                    }
                } while (!cont);

                GamePlay.AlienStillAlive(alien);

            } while (marine.Health > 0 && alien.Health > 0);

            return GamePlay.StillAlive(marine);
        }

        public static Alien MarineAttack(SpaceMarine marine, Alien alien)
        {
            Console.Clear();
            Console.WriteLine("Firing {marine.CurrentWeapon}!!");
            Random rdn = new Random();
            var attack = rdn.Next(1, marine.AttackStrength + 1);

            alien.Health -= attack;

            Console.WriteLine($"You inflicted {attack} damage!");
            Thread.Sleep(3000);

            return alien;
        }

        public static SpaceMarine AlienAttack(SpaceMarine marine, Alien alien)
        {
            Console.WriteLine($"The {alien.Name} is attacking!!");
            Random rdn = new Random();
            var attack = rdn.Next(1, alien.AttackStrength + 1);

            if (marine.Armor > 0)
            {
                marine.Armor -= attack;
                Console.WriteLine($"Your armor sustained {attack} damage!");
                Thread.Sleep(3000);
            }
            else
            {
                marine.Health -= attack;
                Console.WriteLine($"You sustained {attack} damage!");
                Thread.Sleep(3000);
            }

            return marine;
        }

        public static SpaceMarine RunAway(SpaceMarine marine, Alien alien)
        {
            var stillAlive = true;
            marine.RanAway = true;

            stillAlive = (marine.Speed < alien.Speed) ? false : true;

            if (stillAlive == false)
            {
                GamePlay.MarineDeath(marine);
            }

            GamePlay.MarineRanSurvived(marine);

            return marine;
        }

        public static void CurrentStats(SpaceMarine marine, Alien alien)
        {
            Console.Clear();
            Console.WriteLine($"Your current Health: {marine.Health}");
            Console.WriteLine($"Your current Armor: {marine.Armor}");
            Console.WriteLine();
            Console.WriteLine($"The {alien.Name}'s current Health: {alien.Health}");
            Console.WriteLine();
            Thread.Sleep(5000);
        }
    }
}
