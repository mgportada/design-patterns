

using Game.Interfaces;
using Game.Powerups;

namespace Game.Factories
{
    public class RandomPowerUpFactory
    {
        public IPowerUp createPowerUp()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            switch (randomNumber)
            {
                case 0:
                    return new MushroomLife();
                case 1:
                    return new Star();
                default:
                    return new FireFlower();
            }
        }
    }
}
