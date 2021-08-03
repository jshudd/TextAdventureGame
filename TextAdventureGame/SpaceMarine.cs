using System;
namespace TextAdventureGame
{
    public class SpaceMarine : IWeapons, IArmor
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
        public int AttackStrength { get; set; }
        public int Armor { get; set; }
        public int Speed { get; set; } = 100;
        public int AliensToKill { get; set; } = 3;
        public int Ammo { get; set; }
        public int Grenades { get; set; } = 2;

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
        }

        public void MedArmor()
        {
            Speed -= 25;
            Armor += 50;
        }

        public void HeavyArmor()
        {
            Speed -= 50;
            Armor += 100;
        }

        public void PulseRifle()
        {
            AttackStrength = 85;
            Speed -= 10;
            Ammo = 200;
        }

        public void Shotgun()
        {
            AttackStrength = 100;
            Speed -= 20;
            Ammo = 100;
        }

        public void Pistol()
        {
            AttackStrength = 25;
            Ammo = 200;
        }

        public void SmartGun()
        {
            AttackStrength = 120;
            Speed -= 50;
            Ammo = 300;
        }

        public void FlameThrower()
        {
            AttackStrength = 75;
            Speed -= 30;
            Ammo = 100;
        }
    }
}
