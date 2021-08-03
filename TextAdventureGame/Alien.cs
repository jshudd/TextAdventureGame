using System;
namespace TextAdventureGame
{
    public abstract class Alien
    {
        public abstract string Name { get; set; }
        public abstract int Health { get; set; }
        public abstract int AttackStrength { get; set; }
        public abstract int Speed { get; set; }

        public abstract int Attack();
        public abstract void HealthDamage(int attackStrength);

        public virtual void Death()
        {
            Console.WriteLine("The alien has been killed.");
        }
    }
}
