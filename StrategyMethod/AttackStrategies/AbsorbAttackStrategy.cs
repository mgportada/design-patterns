
using System.Threading.Tasks;

namespace StrategyMethod.AttackStrategies
{
    public class AbsorbAttackStrategy: IAttackStrategy
    {
        public void ExecuteAttack(BattleState state)
        {
            state.Attacker.Health += state.Target.BasicAttackDamage;
            state.Target.Health -= state.Attacker.BasicAttackDamage;
            Console.WriteLine($"{state.Attacker.Name} realiza un ataque absorber a {state.Target.Name}.");
        }
    }
}
