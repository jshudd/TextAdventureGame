using System;
namespace TextAdventureGame
{
    public interface IArmor
    {
        public int Armor { get; set; }
        
        public void LightArmor();

        public void MedArmor();

        public void HeavyArmor();
    }    
}
