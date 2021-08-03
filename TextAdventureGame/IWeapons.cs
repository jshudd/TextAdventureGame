using System;
namespace TextAdventureGame
{
    public interface IWeapons
    {
        public int Ammo { get; set; }
        public int Grenades { get; set; }
        
        public virtual void PulseRifle() { }

        public void Shotgun();

        public void Pistol();

        public void SmartGun();

        public void FlameThrower();
    }
}
