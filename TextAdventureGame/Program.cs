using System;
using System.Threading;

namespace TextAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetWindowSize(160, 48);
            
            //change console bkgnd to Black; Text to White
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            //Check OS of computer
            OperatingSystem os = Environment.OSVersion;
            Console.WriteLine(os);
            
            GamePlay.StartUpLogo();
            Console.Clear();

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

                    marine = Combat.Battle(marine, alien);

                    if (!marine.StillAlive)
                    {
                        break;
                    }

                } while (marine.AliensToKill > 0 && marine.StillAlive);

            } while (marine.StillAlive && marine.AliensToKill > 0);

            //create Queen object and run battle again
            marine = GamePlay.StillAlive(marine);

            Console.Clear();
            Console.WriteLine($"While there's a lull, fix your armor.");
            marine = GamePlay.GearUpArmor(marine);

            Alien queen = GamePlay.GenerateQueen();

            marine = Combat.Battle(marine, queen);

            GamePlay.EndGame(marine);

            Environment.Exit(0);
        }
    }
}
