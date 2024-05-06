using StrategyMethod.AttackStrategies;

namespace StrategyMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Configuración de los personajes
            Character player = new Character { Name = "Jugador", Health = 100, BasicAttackDamage = 20 };
            Character enemy = new Character { Name = "Enemigo", Health = 80, BasicAttackDamage = 15 };

            // Estado de la batalla
            BattleState state = new BattleState { Attacker = player, Target = enemy };


            // Estrategias de ataque
            IAttackStrategy playerAttack = new BasicAttackStrategy();
            IAttackStrategy enemyAttack = new AbsorbAttackStrategy();

            // Manejador de turnos
            TurnManager turnManager = new TurnManager();
            turnManager.ComputeTurn(state, playerAttack, enemyAttack);
        }
    }
}