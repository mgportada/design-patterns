

namespace StrategyMethod.AttackStrategies
{
    public class BasicAttackStrategy : IAttackStrategy
    {
        public void ExecuteAttack(BattleState state)
        {
            state.Target.Health -= state.Attacker.BasicAttackDamage;
            Console.WriteLine($"{state.Attacker.Name} realiza un ataque básico a {state.Target.Name}.");
        }
    }
}
