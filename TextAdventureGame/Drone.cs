using System;
namespace TextAdventureGame
{
    public class Drone : Alien
    {
        public Drone()
        {
        }

        public override string Name { get; set; }
        public override int Health { get; set; }
        public override int AttackStrength { get; set; }
        public override int Speed { get; set; }

        public override int Attack()
        {
            throw new NotImplementedException();
        }

        public override void HealthDamage(int attackStrength)
        {
            throw new NotImplementedException();
        }
    }
}
