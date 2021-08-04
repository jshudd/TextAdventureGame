using System;
using System.Collections.Generic;

namespace TextAdventureGame
{
    public class SpaceMarine
    {
        public SpaceMarine()
        {
        }

        public SpaceMarine(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public bool StillAlive { get; set; } = true;
        public int AttackStrength { get; set; }
        public int Armor { get; set; }
        public int Speed { get; set; } = 100;
        public int Grenades { get; set; } = 2;
        public string CurrentWeapon { get; set; }
        public string CurrentArmor { get; set; }
        public int AliensToKill { get; set; } = 3;
        public int Ammo { get; set; }
        public bool RanAway { get; set; }
        public static List<string> WeaponList { get; set; } = new List<string>()
        {
            "Pulse Rifle",
            "Shotgun",
            "Pistol",
            "Smartgun",
            "Flamethrower"
        };
        public static List<string> ArmorList { get; set; } = new List<string>()
        {
            "Light Armor",
            "Medium Armor",
            "Heavy Armor"
        };

        public int Attack()
        {
            Random rdn = new Random();
            return rdn.Next(1, this.AttackStrength);
        }

        public void HealthDamage(int alienAttack)
        {
            Health -= alienAttack;
        }

        public void ArmorDamage(int alienAttack)
        {
            Armor -= alienAttack;
        }

        public void LightArmor()
        {
            Armor += 25;
            CurrentArmor = "Light Armor";
        }

        public void MedArmor()
        {
            Speed -= 25;
            Armor += 50;
            CurrentArmor = "Medium Armor";
        }

        public void HeavyArmor()
        {
            Speed -= 50;
            Armor += 100;
            CurrentArmor = "Heavy Armor";
        }

        public void PulseRifle()
        {
            AttackStrength = 85;
            Speed -= 10;
            Ammo = 200;
            CurrentWeapon = "Pulse Rifle";
        }

        public void Shotgun()
        {
            AttackStrength = 100;
            Speed -= 20;
            Ammo = 100;
            CurrentWeapon = "Shotgun";
        }

        public void Pistol()
        {
            AttackStrength = 25;
            Ammo = 200;
            CurrentWeapon = "Pistol";
        }

        public void SmartGun()
        {
            AttackStrength = 120;
            Speed -= 50;
            Ammo = 300;
            CurrentWeapon = "SmartGun";
        }

        public void FlameThrower()
        {
            AttackStrength = 75;
            Speed -= 30;
            Ammo = 100;
            CurrentWeapon = "Flame Thrower";
        }
    }
}
