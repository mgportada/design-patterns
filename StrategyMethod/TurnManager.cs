
using StrategyMethod.AttackStrategies;

namespace StrategyMethod
{
    public class TurnManager
    {
        public void ComputeTurn(BattleState state, IAttackStrategy playerAttack, IAttackStrategy enemyAttack)
        {
            // Realiza el ataque del jugador
            playerAttack.ExecuteAttack(state);

            // Realiza el ataque del enemigo
            enemyAttack.ExecuteAttack(state);
        }
    }
}
