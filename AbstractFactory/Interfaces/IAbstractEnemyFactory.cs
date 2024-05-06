
using Game.Interfaces;

namespace Game
{
    public interface IAbstractEnemyFactory
    {
        public IEnemy createEnemy();
    }
}
