using System;
using System.Threading;

namespace TextAdventureGame
{
    public static class GamePlay
    {
        public static void StartUpLogo()
        {
            string title = @"
   _____                          __  ___           _          
  / ___/____  ____ _________     /  |/  /___ ______(_)___  ___ 
  \__ \/ __ \/ __ `/ ___/ _ \   / /|_/ / __ `/ ___/ / __ \/ _ \
 ___/ / /_/ / /_/ / /__/  __/  / /  / / /_/ / /  / / / / /  __/
/____/ .___/\__,_/\___/\___/  /_/  /_/\__,_/_/  /_/_/ /_/\___/ 
    /_/                                                        
";

            Console.WriteLine(title);
            Thread.Sleep(8000);
            Console.Clear();
        }

        public static SpaceMarine StartUp()
        {
            //Intro to game
            SpaceMarine marine = new SpaceMarine();

            Console.WriteLine("WAKE UP SPACE MARINE!! We're under attack!!");
            Console.WriteLine();
            Console.WriteLine("What's your name Marine?!");
            marine.Name = Console.ReadLine();

            Console.Clear();
            return marine;
        }

        public static SpaceMarine GearUpArmor(SpaceMarine marine)
        {
            bool cont = false;

            Console.WriteLine("Run to the armory and gear up!!");
            Console.WriteLine("Make sure you choose the right combination to ensure victory.");
            Thread.Sleep(4000);
            
            do
            {
                Console.Clear();
                Console.WriteLine("Choose your body armor.");
                Console.WriteLine();
                Console.WriteLine("Light: Some protection but won't slow you down.");
                Console.WriteLine("Medium: Better protection but makes you slower.");
                Console.WriteLine("Heavy: Great protection but you're a turtle.");
                Console.WriteLine();
                Console.WriteLine("Enter your choice:");
                var response = Console.ReadLine();
                Console.WriteLine();

                switch(response.ToLower())
                {
                    case "light":
                    case "l":
                        marine.LightArmor();
                        cont = true;
                        break;
                    case "medium":
                    case "m":
                    case "med":
                        marine.MedArmor();
                        cont = true;
                        break;
                    case "heavy":
                    case "h":
                        marine.HeavyArmor();
                        cont = true;
                        break;
                    default:
                        Console.WriteLine("Choice not recognized. Try again.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }

            } while (!cont);

            Console.Clear();
            Console.WriteLine("Great choice. Hope it was the right one...");
            Thread.Sleep(5000);
            Console.Clear();
            return marine;
        }

        public static SpaceMarine GearUpWeapon(SpaceMarine marine)
        {
            bool cont = false;
            
            do
            {
                Console.WriteLine("Choose your Weapon.");
                Console.WriteLine();
                Console.WriteLine("M41A Pulse Rifle (M41A): 10mm Explosive tip caseless. Standard Light Armor Piercing Round; 99 of 'em.");
                Console.WriteLine("M56 SmartGun (M56): Beltfed, lead-slinging hate machine. Heavy though.");
                Console.WriteLine("Shotgun: For close encounters.");
                Console.WriteLine("M240 Flame Thrower (M240): Smoke 'em if you've got 'em.");
                Console.WriteLine("Pistol: Small and light. Doesn't hit as hard.");
                Console.WriteLine();
                var response = Console.ReadLine();

                switch (response.ToLower())
                {
                    case "pulse":
                    case "pulse rifle":
                    case "pulserifle":
                    case "m41a":
                        marine.PulseRifle();
                        cont = true;
                        break;
                    case "smartgun":
                    case "smart":
                    case "smart gun":
                    case "m56":
                        marine.SmartGun();
                        cont = true;
                        break;
                    case "shotgun":
                    case "shot gun":
                        marine.Shotgun();
                        cont = true;
                        break;
                    case "flamethrower":
                    case "flame thrower":
                    case "m240":
                        marine.FlameThrower();
                        cont = true;
                        break;
                    case "pistol":
                        marine.Pistol();
                        cont = true;
                        break;
                    default:
                        Console.WriteLine("Choice not recognized. Try again.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }

            } while (!cont);

            Console.Clear();
            Console.WriteLine("You're locked and loaded.");
            Console.WriteLine($"Move it, {marine.Name}! The Corp ain't payin' you by the hour!!");
            Thread.Sleep(5000);
            Console.Clear();

            return marine;
        }

        public static int RandomAlien()
        {
            //generates Random number for Alien to battle
            Random randomAlien = new Random();
            var pick = randomAlien.Next(1, 3);
            return pick;
        }

        public static Alien GenerateAlien(int pick)
        {
            //Generates alien based on # generated above
            Console.Clear();
            Console.WriteLine("Get ready!! Scanners detecting movement!!!");
            Thread.Sleep(5000);
            Console.Clear();

            Alien alien1 = new FaceSucker();
            Alien alien2 = new Xenomorph();

            Console.WriteLine((pick == 1) ? "Lookout it's a FaceSucker!" : "Oh no! It's a Xenomorph!");
            Thread.Sleep(5000);
            return (pick == 1) ? alien1 : alien2;
        }

        public static Alien GenerateQueen()
        {
            //Generates Queen
            Console.Clear();
            Console.WriteLine("Oh no!! Scanners are detecting something BIG!!!");
            Thread.Sleep(5000);
            
            Alien queen = new Queen();

            Console.Clear();
            Console.WriteLine($"That's a Queen!! Game over, man! Game over!!!");
            Thread.Sleep(5000);
            return queen;
        }

        public static SpaceMarine StillAlive(SpaceMarine marine)
        {
            if(marine.Health <= 0)
            {
                marine.StillAlive = false;
                MarineDeath(marine);
            }

            return marine;
        }

        public static void MarineDeath(SpaceMarine marine)
        {   
            if (marine.RanAway)
            {
                Console.Clear();
                Console.WriteLine($"We regret to inform you that {marine.Name} ran away but was too slow and was overwhelmed by the aliens.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"{marine.Name} fought bravely and with honor but was overcome by the aliens.");                
            }

            Console.WriteLine("What little remains will be buried back on Earth.");
            Thread.Sleep(6000);
            Environment.Exit(0);
        }

        public static void MarineSurvived(SpaceMarine marine)
        {
            Console.Clear();
            Console.WriteLine($"Congrats {marine.Name}! You fought hard and survived all of the aliens, including the Queen.");
            Console.WriteLine($"You've saved the day and deserve a medal. We need more Marines like you.");
            Thread.Sleep(5000);
            Environment.Exit(0);
        }

        public static void MarineRanSurvived(SpaceMarine marine, Alien alien)
        {
            Console.Clear();
            Console.WriteLine($"{marine.Name} quickly retreated to a safe location. Many other marines died due to your choice, though");
            Console.WriteLine($"The {alien.Name} will probably find you again soon...");
            Thread.Sleep(5000);
            Console.WriteLine($"IT FOUND YOU!!");
            Thread.Sleep(3000);
        }

        public static SpaceMarine AlienStillAlive(SpaceMarine marine, Alien alien)
        {
            Console.Clear();
            if(alien.Health <= 0)
            {
                Console.Clear();
                switch (alien.Name)
                {
                    case "FaceSucker":
                        Console.WriteLine($"You squashed the {alien.Name}!!");
                        break;
                    case "Xenomorph":
                        Console.WriteLine($"The {alien.Name} has been killed. Don't get burned by the acidic blood!");
                        break;
                    case "Queen":
                        Console.WriteLine($"The {alien.Name} has been destroyed. There will be no more eggs!");
                        break;
                    default:
                        Console.WriteLine($"You killed the {alien.Name}!!");
                        break;
                }
                Thread.Sleep(3000);
                marine.AliensToKill--;
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"The {alien.Name} is still alive and fighting! Look out!!");
            }

            return marine;
        }

        public static void EndGame(SpaceMarine marine)
        {
            if (marine.StillAlive)
            {
                GamePlay.MarineSurvived(marine);
            }
            else
            {
                GamePlay.MarineDeath(marine);
            }
        }
    }
}
