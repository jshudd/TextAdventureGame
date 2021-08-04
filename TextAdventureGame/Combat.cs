using System;
namespace TextAdventureGame
{
    public static class Combat
    {
        public static bool Battle(SpaceMarine marine, Alien alien)
        {
            bool stillAlive = true;

            Console.Clear();
            Console.WriteLine($"A {alien.Name} is attacking!!");
            do
            {
                var cont = true;

                Console.WriteLine($"Marine Health: {marine.Health}");
                Console.WriteLine($"Marine Armor: {marine.Armor}");
                Console.WriteLine();
                Console.WriteLine($"{alien.Name} Health: {alien.Health}");
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
                            cont = false;
                            break;
                        case "attack":
                            cont = false;
                            break;
                        default:
                            Console.WriteLine("Try again.");
                            break;
                    }
                } while (cont);

                MarineAttack(marine, alien);

                AlienAttack(marine, alien);

            } while (marine.Health > 0 && alien.Health > 0);

            return stillAlive = (marine.Health > 0) ? true : false;
        }

        public static Alien MarineAttack(SpaceMarine marine, Alien alien)
        {
            Console.Clear();
            Console.WriteLine("Firing {marine.CurrentWeapon}!!");
            Random rdn = new Random();
            var attack = rdn.Next(1, marine.AttackStrength + 1);

            alien.Health -= attack;

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
            }
            else
            {
                marine.Health -= attack;
            }

            return marine;
        }

        public static bool RunAway(SpaceMarine marine, Alien alien)
        {
            bool stillAlive = true;

            return stillAlive = (marine.Speed < alien.Speed) ? false : true;

            //IDEA: rather than returning a bool; 
        }
    }
}
