using Game.Interfaces;
using Game.Powerups;

namespace AbstractFactory.Factories
{
    public class RandomPowerUpFactory
    {
        public IPowerUp createPowerUp()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 4);
            switch (randomNumber)
            {
                case 0:
                    return new MushroomLife();
                case 1:
                    return new Star();
                case 2:
                    return new FireFlower();
                default:
                    return new Feather();
            }
        }
    }
}
