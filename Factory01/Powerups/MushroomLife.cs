

using Game.Interfaces;

namespace Game.Powerups
{
    public class MushroomLife : IPowerUp
    {
        public void usePowerUp()
        {
            Console.WriteLine("MushroomLife used! You have an extra life!");
        }
    }
}
