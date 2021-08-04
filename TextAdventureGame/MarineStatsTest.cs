using System;
namespace TextAdventureGame
{
    public class MarineStatsTest
    {
        public MarineStatsTest()
        {
        }

        public static void MarineStats(SpaceMarine marine)
        {
            Console.WriteLine($"Name: {marine.Name}");
            Console.WriteLine($"Health: {marine.Health}");
            Console.WriteLine($"AttackStrength: {marine.AttackStrength}");
            Console.WriteLine($"Armor: {marine.Armor}");
            Console.WriteLine($"Speed: {marine.Speed}");
            Console.WriteLine($"Grenades: {marine.Grenades}");
            Console.WriteLine($"Current Weapon: {marine.CurrentWeapon}");
            Console.WriteLine($"Current Armor: {marine.CurrentArmor}");
            Console.WriteLine($"Aliens To Kill: {marine.AliensToKill}");
            Console.WriteLine($"Ammo: {marine.Ammo}");
            Console.WriteLine();
        }
    }
}
