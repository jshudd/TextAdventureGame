using System;
namespace TextAdventureGame
{
    public class FaceGrabber :Alien
    {
        public FaceGrabber()
        {
        }

        public override string Name { get; set; } = "FaceGrabber";
        public override int Health { get; set; } = 25;
        public override int AttackStrength { get; set; } = 25;
        public override int Speed { get; set; } = 100;

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
            Console.WriteLine("The FaceGrabber has died.");
        }
    }
}
