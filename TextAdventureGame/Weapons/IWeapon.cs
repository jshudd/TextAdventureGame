using System;
namespace TextAdventureGame
{
    public interface IWeapon
    {
        public int AttackStrength { get; set; }
        public int Ammo { get; set; }
                
        public virtual void PulseRifleEquip() { }

        public virtual void ShotgunEquip() { }

        public virtual void PistolEquip() { }

        public virtual void SmartGunEquip() { }

        public virtual void FlameThrowerEquip() { }
    }
}
