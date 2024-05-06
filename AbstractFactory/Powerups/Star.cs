
using Game.Interfaces;

namespace Game.Powerups
{
    public class Star : IPowerUp
    {
        public void usePowerUp()
        {
            Console.WriteLine("Start used! You are invincible!");
        }
    }
}
