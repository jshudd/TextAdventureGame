using System;
namespace TextAdventureGame
{
    public static class GamePlay
    {
        public static void StartUp()
        {
            //Intro to game
            throw new NotImplementedException();
        }

        public static int RandomAlien()
        {
            //generates Random Alien to battle
            Random randomAlien = new Random();
            var pick = randomAlien.Next(1, 2);
            return pick;
        }

        public static Alien GenerateAlien()
        {
            //Generates alien based on # generated above
            throw new NotImplementedException();
        }
    }
}
