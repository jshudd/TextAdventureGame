using System;
using System.Threading;

namespace TextAdventureGame
{
    public static class GamePlay
    {
        public static SpaceMarine StartUp()
        {
            //Intro to game
            SpaceMarine marine = new SpaceMarine();

            Console.WriteLine("SPACE MARINE");
            Thread.Sleep(5000);
            Console.Clear();

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
            Console.WriteLine();
            do
            {
                Console.WriteLine("Choose your body armor.");
                Console.WriteLine("Light: Some protection but won't slow you down.");
                Console.WriteLine("Medium: Better protection but makes you slower.");
                Console.WriteLine("Heavy: Great protection but you're a turtle.");
                Console.WriteLine("Enter your choice:");
                var response = Console.ReadLine();
                Console.WriteLine();

                switch(response.ToLower())
                {
                    case "light":
                        marine.LightArmor();
                        cont = true;
                        break;
                    case "medium":
                        marine.MedArmor();
                        cont = true;
                        break;
                    case "heavy":
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
            Thread.Sleep(4000);
            return marine;
        }

        public static SpaceMarine GearUpWeapon(SpaceMarine marine)
        {
            bool cont = false;
            
            do
            {
                Console.WriteLine("Choose your Weapon.");
                Console.WriteLine("M41A Pulse Rifle: 10mm Explosive tip caseless. Standard Light Armor Piercing Round; 99 of 'em.");
                Console.WriteLine("M56 SmartGun: Beltfed, lead-slinging hate machine. Heavy though.");
                Console.WriteLine("Shotgun: For close encounters.");
                Console.WriteLine("M240 Flame Thrower: Smoke 'em if you've got 'em.");
                Console.WriteLine("Pistol: Small and light. Doesn't hit as hard.");
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
            Console.WriteLine($"Move it, {marine.Name}! The Corp ain't payin you by the hour!!");
            Thread.Sleep(5000);

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
            Console.WriteLine("Get ready!! Scanners detecting movement!!!");
            Thread.Sleep(5000);
            Console.Clear();

            Alien alien1 = new FaceSucker();
            Alien alien2 = new Xenomorph();

            Console.WriteLine((pick == 1) ? "Lookout it's a FaceSucker!" : "Oh no! It's a Xenomorph!");
            return (pick == 1) ? alien1 : alien2;
        }
    }
}
