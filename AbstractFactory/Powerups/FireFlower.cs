

using Game.Interfaces;

namespace Game.Powerups
{
    public class FireFlower : IPowerUp
    {
        public void usePowerUp()
        {
            Console.WriteLine("Fire Flower used to shoot fireballs!");
        }
    }
}
