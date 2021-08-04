using System;
using System.Threading;

namespace TextAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var marine = GamePlay.StartUp();
            Console.Clear();

            marine = GamePlay.GearUpArmor(marine);
            Console.Clear();

            marine = GamePlay.GearUpWeapon(marine);
            Console.Clear();

            //test Marine object
            MarineStatsTest.MarineStats(marine);


        }
    }
}
