using Game.Interfaces;

namespace Game.Powerups
{
    public class Feather : IPowerUp
    {
        public void usePowerUp()
        {
            Console.WriteLine("Feather used! Fly away!");
        }
    }
}
