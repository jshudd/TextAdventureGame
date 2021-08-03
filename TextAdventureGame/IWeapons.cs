using System;
namespace TextAdventureGame
{
    public interface IWeapons
    {
        public int Ammo { get; set; }
        public int Grenades { get; set; }

        public void PulseRifle();

        public void FlameThrower();

        public void Pistol();

        public void SmartGun();
    }
}
