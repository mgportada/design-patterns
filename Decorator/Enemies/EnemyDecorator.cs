
namespace Decorator.Enemies
{
    public abstract class EnemyDecorator : Enemy
    {
        protected Enemy _enemy;

        public EnemyDecorator(Enemy enemy)
        {
            _enemy = enemy;
        }

        public override int ComputeDamage(Attack receivedAttack)
        {
            return _enemy.ComputeDamage(receivedAttack);
        }
    }


}
