using System;
namespace TextAdventureGame
{
    public class Queen : Alien
    {
        public Queen()
        {
        }

        public override string Name { get; set; } = "Queen";
        public override int Health { get; set; } = 150;
        public override int AttackStrength { get; set; } = 120;
        public override int Speed { get; set; } = 80;

        public override int Attack()
        {
            Random rdn = new Random();
            return rdn.Next(1, this.AttackStrength);
        }

        public override void HealthDamage(int attackStrength)
        {
            Health -= attackStrength;
        }

        public override void Death()
        {
            Console.WriteLine("The Queen has been destroyed. There will be no more eggs!");
        }
    }
}
