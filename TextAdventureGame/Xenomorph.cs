using System;
namespace TextAdventureGame
{
    public class Xenomorph : Alien
    {
        public Xenomorph()
        {
        }

        public override string Name { get; set; } = "Xenomorph";
        public override int Health { get; set; } = 100;
        public override int AttackStrength { get; set; } = 100;
        public override int Speed { get; set; } = 60;

        public override int Attack()
        {
            Random rdn = new Random();
            return rdn.Next(1, this.AttackStrength);
        }

        public override void HealthDamage(int attackStrength)
        {
            Health -= attackStrength;
        }
    }
}
